using MauiPlanets.Models;


namespace MauiPlanets.Services
{
	internal class PlanetsService
	{
		private static List<Planet> planets = new()
		{
			new()
			{
				Name = "Mercury",
				Subtitle = "The smallest planet",
				HeroImage = "mercury.png",
				Description = "Mercury is the first planet from the Sun and the smallest in the Solar System. " +
							"In English, it is named after the ancient Roman god Mercurius (Mercury), god of commerce and " +
							"communication, and the messenger of the gods. ",
				AccentColorStart = Color.FromArgb("#353535"),
				AccentColorEnd = Color.FromArgb("#8d9098"),
				Images = new()
				{
					"https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://www.nhm.ac.uk/content/dam/nhm-www/discover/mercury-facts/mercury-factfile-v2-full-width.jpg.thumb.1920.1920.png",
					"https://griffithobservatory.org/wp-content/uploads/2021/03/Mercury_fin_flood_LD_V3-1600x844.jpg"
				}
			},
			new()
			{
				Name = "Venus",
				Subtitle = "The pressure cooker",
				HeroImage = "venus.png",
				Description = "Of all the planets, Venus is the one most similar to Earth. In fact, " +
							"Venus is often called Earth's “sister” planet. As similar as it is in some ways, " +
							"however, it is also very different in others. ",
				AccentColorStart = Color.FromArgb("#a6393b"),
				AccentColorEnd = Color.FromArgb("#d17f21"),
				Images = new()
				{
					"https://cdn.mos.cms.futurecdn.net/RifjtkFLBEFgzkZqWEh69P-1200-80.jpg",
                    "https://cdn.shortpixel.ai/spai/q_lossy+w_834+h_794+to_auto+ret_img/cosmosmagazine.com/wp-content/uploads/2020/04/venus_resized.jpg",
					"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSRIK8HsPuD9mo2NePF9ZOpGjGFeHeB5g41wUYG51uCFvewSBAv4Fl1ZBGgYjBhNMjsJaA&usqp=CAU"

				}
			},
			new()
			{
				Name = "Earth",
				Subtitle = "The cradle of life",
				HeroImage = "earth.png",
				Description = "The Earth is the only planet known where life exists. Almost 1.5 million species " +
							"of animals and plants have been discovered so far, and many more have yet to be found. While other " +
							"planets may have small amounts of ice or steam, the Earth is 2/3 water. Earth has perfect conditions " +
							"for a breathable atmosphere. ",
				AccentColorStart = Color.FromArgb("#0e3d68"),
				AccentColorEnd = Color.FromArgb("#2e97c7"),
				Images = new()
				{
					"https://res.cloudinary.com/jerrick/image/upload/d_642250b563292b35f27461a7.png,f_jpg,fl_progressive,q_auto,w_1024/63e0ae1d227cb3001dcfcedd.jpg",
					"https://www.farmersalmanac.com/wp-content/uploads/2020/11/Exceptional-earth.jpg",
					"https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778"
				}
			},
			new()
			{
				Name = "Mars",
				Subtitle = "The red beauty",
				HeroImage = "mars.png",
				Description = "No planet has sparked the imaginations of humans as much as Mars. " +
							"It may be the reddish color of Mars, or the fact that it can often be easily seen " +
							"in the night sky, that has caused people to wonder about this close neighbor of ours. " +
							"Tales of “Martians” invading Earth have been around for well over fifty years. But is " +
							"it likely that any kind of life really does exist on Mars? ",
				AccentColorStart = Color.FromArgb("#a23036"),
				AccentColorEnd = Color.FromArgb("#eb3333"),
				Images = new()
				{
					"https://www.worldatlas.com/upload/bb/c3/32/shutterstock-1041249343.jpg",
					"https://www.frostscience.org/wp-content/uploads/2023/01/Mars-blog-header-1024x576.png",
					"https://miro.medium.com/v2/resize:fit:1200/1*2n6yiV0A8p8Lyk55gId23Q.jpeg"
				}
			},
			new()
			{
				Name = "Jupiter",
				Subtitle = "The gas giant",
				HeroImage = "jupiter.png",
				Description = "Jupiter is the fifth planet from the Sun and the largest in the Solar System. " +
							"It is a gas giant with a mass more than 2.5 times that of all the other planets in the Solar " +
							"System combined, and slightly less than one-thousandth the mass of the Sun.",
				AccentColorStart = Color.FromArgb("#9d4a40"),
				AccentColorEnd = Color.FromArgb("#cd8026"),
				Images = new()
				{
					"https://i0.wp.com/geolearn.in/wp-content/uploads/2020/12/image-187.png?fit=614%2C384&ssl=1",
					"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQfNDiO-vgPbwZ_hn1-urOWQw-4FYyXVcH1mA&s",
					"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT5Mc_u3Kd8JZkjGM4D5CVkfPxisrORr-bWhg&s"
				}
			},
			new()
			{
				Name = "Saturn",
				Subtitle = "The ring planet",
				HeroImage = "saturn.png",
				Description = "Saturn is the sixth planet from the Sun and the second largest in the Solar System, " +
							"after Jupiter. It is a gas giant, with an average radius of about nine times that of Earth. Saturn's " +
							"interior is thought to be composed of a rocky core, surrounded by a deep layer of metallic hydrogen, " +
							"an intermediate layer of liquid hydrogen and liquid helium, and an outer layer of gas.",
				AccentColorStart = Color.FromArgb("#996237"),
				AccentColorEnd = Color.FromArgb("#c6502f"),
				Images = new()
				{
					"https://cf-img-a-in.tosshub.com/sites/visualstory/wp/2024/06/Saturn1.jpeg?size=*:900",
					"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRl5NX24CQTZ0OB9T9BYoA2xlI2fc2bTUDAHA&s",
					"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS1elU2tkBub1odubHywTxL1StYHoGRsv_Dww&s"
				}
			},
			new()
			{
				Name = "Uranus",
				Subtitle = "The Herschel planet",
				HeroImage = "uranus.png",
				Description = "Uranus is the seventh planet from the Sun. It is a gaseous cyan-coloured ice giant. " +
							"Most of the planet is made of water, ammonia, and methane in a supercritical phase of matter, which " +
							"astronomy calls 'ice' or volatiles. The planet's atmosphere has a complex layered cloud structure and " +
							"has the lowest minimum temperature (49 K (−224 °C; −371 °F)) of all the Solar System's planets.",
				AccentColorStart = Color.FromArgb("#9d4a40"),
				AccentColorEnd = Color.FromArgb("#996237"),
				Images = new()
				{
					"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTO6KXc87281zVEO7z9cUId7-nqBOglXNdgyA&s",
					"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSG8CQzihe85ZwOPAGBE-JooA_hDUGirVmeHw&s",
					"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQdhFjYwfwG7-4c3mT-TB-y8JutZC_i6_cv0Q&s"
				}
			},
			new()
			{
				Name = "Neptune",
				Subtitle = "The god of the sea",
				HeroImage = "neptune.png",
				Description = "Neptune is the eighth and farthest known planet from the Sun. It is the " +
							"fourth-largest planet in the Solar System by diameter, the third-most-massive planet, " +
							"and the densest giant planet. It is 17 times the mass of Earth and slightly more massive, " +
							"but denser and smaller, than fellow ice giant Uranus.",
				AccentColorStart = Color.FromArgb("#0c293d"),
				AccentColorEnd = Color.FromArgb("#26abe0"),
				Images = new()
				{
					"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSOE0lFUuYQKRPDF5Jnpw40XpyuOUpKfLLXBA&s",
					"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTKYtK1rw-bMdomPmONkGk3cREGm79I_nSPJg&s",
					"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ1hyWzldCX3g_BWDTb-chlv-2elXM90qbZcw&s"
				}
			},
			new()
			{
				Name = "Pluto",
				Subtitle = "Pluto enjoyed decades of special status as one of the solar system's planets.",
				HeroImage = "pluto.png",
				Description = "Discovered in 1930, Pluto was long considered our solar system's ninth planet until its " +
                "reclassification in 2006. With a diameter of about 2,377 kilometers, this icy world orbits the Sun at an average " +
                "distance of 5.9 billion kilometers, taking 248 Earth years to complete one orbit. Despite its small size, " +
                "Pluto has five known moons, with Charon being the largest.",
                AccentColorStart = Color.FromArgb("#ae7e60"),
				AccentColorEnd = Color.FromArgb("#bdab9f"),
				Images = new()
				{
					"https://oap.unige.ch/journals/public/journals/8/submission_847_810_coverImage_en_US.jpg",
					"https://i.natgeofe.com/n/d37ef874-0dc6-4cd4-b244-74d6b3f7232c/Pluto4.jpg",
					"https://cdn.mos.cms.futurecdn.net/DoZSMXF87kCuzbymsuEFHo.jpg"
				}
			},
			new()
			{
				Name = "Ceres",
				Subtitle = "Ceres is named for the Roman goddess of corn and harvests.",
				HeroImage = "ceres.png",
				Description = "Located in the asteroid belt between Mars and Jupiter, Ceres was the first asteroid ever " +
                "discovered in 1801. With a diameter of approximately 940 kilometers, it comprises about one-third of the " +
                "asteroid belt's total mass. In 2015, NASA's Dawn spacecraft revealed Ceres has a rocky interior, an ice-rich " +
                "crust, and possibly a subsurface ocean of briny water. Its surface features numerous craters and mysterious " +
                "bright spots composed of salt deposits.",
                AccentColorStart = Color.FromArgb("#686462"),
				AccentColorEnd = Color.FromArgb("#b8b5b3"),
				Images = new()
				{
					"https://cdn.mos.cms.futurecdn.net/qnft8kRfeGWWLgaygo4fb9.jpg",
					"https://i0.wp.com/eos.org/wp-content/uploads/2016/09/ceres-northern-end.jpg?fit=820%2C615&ssl=1",
					"https://d2cbg94ubxgsnp.cloudfront.net/Pictures/480xany/1/9/8/140198_Ceres_c_NASA-JPL---Caltech-UCLA-MPS-DLR-IDA.jpg"
				}
			},
			new()
			{
				Name = "Haumea_korras",
				Subtitle = "Haumea is named after the Hawaiian goddess of fertility.",
				HeroImage = "haumea.png",
				Description =  "Discovered in 2004, Haumea is one of the strangest dwarf planets in our solar system. " +
                "Its elongated, egg-like shape results from its incredibly rapid rotation, completing one full turn in " +
                "just under 4 hours. Located in the Kuiper Belt beyond Neptune, Haumea has a diameter equivalent to about " +
                "one-third that of Earth's moon. It features a surface composed largely of crystalline water ice and has " +
                "two known moons, Hi'iaka and Namaka. Uniquely, Haumea is also surrounded by a ring system discovered in 2017.",
                AccentColorStart = Color.FromArgb("#757270"),
				AccentColorEnd = Color.FromArgb("#8b8680"),
				Images = new()
				{
					"https://www.centraldatacore.com/wp-content/uploads/PD3-Haumea-P-Key-1200x900.jpg",
                    "https://cdn.mos.cms.futurecdn.net/JMePZFEJNcVnNawYzrCv96-650-80.jpg.webp",
                    "https://www.scienceabc.com/wp-content/uploads/2019/09/This-image-is-a-concept-of-the-Haumea-ellipsoidal-dwarf-planet-with-rings-in-the-Kuiper-belt-Diego-Baruccos.jpg"
                }
			},
			new()
			{
				Name = "MakeMake",
				Subtitle = "Makemake was named after the Rapanui god of fertility.",
				HeroImage = "makemake.png",
				Description = "Named after the creation deity of the Rapa Nui people of Easter Island, Makemake was " +
                "discovered in 2005. This Kuiper Belt object has a reddish hue and a diameter of roughly 1,430 kilometers, " +
                "making it about two-thirds the size of Pluto. Makemake takes approximately 305 Earth years to orbit the " +
                "Sun and has one known moon, discovered in 2016. Its surface is thought to be covered with methane, ethane, " +
                "and possibly nitrogen ices, giving it a reflective appearance that makes it the second brightest Kuiper Belt " +
                "object after Pluto.",
                AccentColorStart = Color.FromArgb("#7c4b34"),
				AccentColorEnd = Color.FromArgb("#9a7567"),
				Images = new()
				{
					"https://cdn.eso.org/images/screen/eso1246a.jpg",
                    "https://cdn.shopify.com/s/files/1/0742/7719/1954/files/Makemake_1024x1024.jpg?v=1693092886",
					"https://cdn.mos.cms.futurecdn.net/8QBGiy9BhmttKdGeAAZpn8.jpg"
				}
			},
			new()
			{
				Name = "Eris",
				Subtitle = "Largest dwarf planet",
				HeroImage = "eris.png",
				Description =  "Discovered in 2005, Eris caused a scientific revolution that led to the redefinition of " +
                "what constitutes a planet. Despite being slightly smaller in diameter than Pluto at about 2,326 kilometers, " +
                "Eris is approximately 27% more massive, making it the most massive known dwarf planet. Orbiting the Sun at an " +
                "average distance of 96 astronomical units (14.4 billion kilometers), Eris takes about 558 Earth years to " +
                "complete one orbit. Its highly reflective surface is covered with methane ice, and it has one known moon " +
                "named Dysnomia.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
				AccentColorEnd = Color.FromArgb("#996237"),
				Images = new()
				{
					"https://cff2.earth.com/uploads/2024/02/20135637/Eris_icy-dwarf-planet_kuiper-belt_1m.jpg",
					"https://static.wikia.nocookie.net/terragenesis/images/8/88/Habitable_Eris.jpg/revision/latest?cb=20210202092847",
					"https://www.bobthealien.co.uk/bobpics/eris_ai.jpg"
				}
			}
		};

		public static List<Planet> GetFeaturedPlanets()
		{
			var random = new Random();
			var randomizePlanets = planets.OrderBy(item => random.Next());

			return randomizePlanets
				.Take(2)
				.ToList();
		}

		public static List<Planet> GetAllPlanets()
			=> planets;
	}
}