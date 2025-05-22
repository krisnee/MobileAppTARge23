using SQLite;
using System.Linq.Expressions;

namespace MauiCRUD.Data
{
	public class DatabaseContext : IAsyncDisposable
	{
		private const string DbName = "CRUDdb3";
		private static string DbPath => Path.Combine(".", DbName);

		private SQLiteAsyncConnection _connection;
		private SQLiteAsyncConnection Database =>
			(_connection ??= new SQLiteAsyncConnection(DbPath,
				SQLiteOpenFlags.Create | SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.SharedCache));

		public async Task<IEnumerable<TTable>> GetAllAsync<TTable>() where TTable : class, new()
		{
			var table = await GetTableAsync<TTable>();
			return await table.ToListAsync();
		}

		private async Task<AsyncTableQuery<TTable>> GetTableAsync<TTable>() where TTable : class, new()
		{
			await CreateTableIfNotExists<TTable>();
			return Database.Table<TTable>();
		}

		private async Task CreateTableIfNotExists<TTable>() where TTable : class, new()
		{
			await Database.CreateTableAsync<TTable>();
		}

		private async Task<TResult> Execute<TTable, TResult>(Func<Task<TResult>> action) where TTable : class, new()
		{
			await CreateTableIfNotExists<TTable>();
			return await action();
		}

		public async Task<TTable> GetItemByKeyAsync<TTable>(object primarykey) where TTable : class, new()
		{
			return await Execute<TTable, TTable>(async () => await Database.GetAsync<TTable>(primarykey));
		}

		public async Task<bool> AddItemAsync<TTable>(TTable item) where TTable : class, new()
		{
			return await Execute<TTable, bool>(async () => await Database.InsertAsync(item) > 0);
		}

		public async Task<bool> UpdateItemAsync<TTable>(TTable item) where TTable : class, new()
		{
			await CreateTableIfNotExists<TTable>();
			return await Database.UpdateAsync(item) > 0;
		}

		public async Task<bool> DeleteItemAsync<TTable>(TTable item) where TTable : class, new()
		{
			await CreateTableIfNotExists<TTable>();
			return await Database.DeleteAsync(item) > 0;
		}

		public async Task<bool> DeleteItemByKeyAsync<TTable>(object primarykey) where TTable : class, new()
		{
			await CreateTableIfNotExists<TTable>();
			return await Database.DeleteAsync<TTable>(primarykey) > 0;
		}

		public async ValueTask DisposeAsync() => await _connection.CloseAsync();

		public async Task<IEnumerable<TTable>> GetFilteredAsync<TTable>(Expression<Func<TTable, bool>> predicate) where TTable : class, new()
		{
			var table = await GetTableAsync<TTable>();
			return await table.Where(predicate).ToListAsync();
		}
	}
}
