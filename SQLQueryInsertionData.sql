-- Inserting data into the Users table
INSERT INTO Users (email, password, isAdmin) VALUES
('max@gmail.com', 'max', 0),
('user@ukr.net', 'user', 0),
('admin@gmail.com', 'admin', 1),
('andrew@ukr.net', 'andrew', 0),
('nazar@gmail.com', 'nazar', 0),
('serhii@gmail.com', 'serhii', 0),
('oleg@gmail.com', 'oleg', 0),
('igor@gmail.com', 'igor', 0),
('sasha@gmail.com', 'sacha', 0),
('denys@ukr.net', 'denys', 0),
('ilya@ukr.net', 'ilya', 0);

-- Inserting data into the Locations table
INSERT INTO Locations (name, description) VALUES
('Lviv Opera', 'One of the most beautiful architectural buildings in Lviv, built in the Renaissance style. A place for opera performances and concerts'),
('St. Sophia Cathedral', 'The ancient Orthodox cathedral, built in the 11th century. Designated as a UNESCO World Heritage Site'),
('Crimean mountains', 'Unique mountains with numerous mountain ranges, caves and beautiful landscapes. An ideal place for tourism and adventure.'),
('Khortytsia Island', 'A historical island on the Dnieper, where Cossack monuments and museums are located. One of the symbols of Ukrainian Cossack history'),
('Podilsk fortress', 'A picturesque fortress standing on a rock in the middle of the river. It dates back to the 12th century and served as a defense structure.'),
('Carpathians', 'Mountain ranges that offer excellent opportunities for mountain tourism, skiing and nature excursions'),
('Radomysl Castle', 'A medieval castle with a unique collection of artistic and historical artifacts'),
('Ostroh Academy', 'Ostroh Academy, located in Ostroh, Rivne Oblast, Ukraine, is one of the oldest institutions of higher education in Eastern Europe.'),
('Church of St. George', 'A stone church in the Gothic style, which is more than 600 years old and is a world heritage site'),
('Nesvytskyi Castle', 'A historic castle in the Renaissance style, which impresses with its architecture and location near the lake');

-- Inserting data into the PointOfInterest table
INSERT INTO PointOfInterest (location_id, name, description, route) VALUES
(1, 'Lviv Opera', 'Lviv, Ukraine. The Lviv Opera House, officially known as the Lviv Theatre of Opera and Ballet, is a cultural gem situated in the heart of Lviv`s historic center. Built in the Viennese Neo-Renaissance style, the opera house is renowned for its architectural beauty and serves as a symbol of Lviv`s rich cultural heritage.', 'Route 1: Cultural capital of Lviv'),
(2, 'St. Sophia Cathedral', 'St. Sophia Cathedral, Kyiv. St. Sophia Cathedral, located in Kyiv, Ukraine, is a UNESCO World Heritage Site and an iconic symbol of the city`s cultural and religious heritage. Dating back to the 11th century, it stands as a masterpiece of Byzantine architecture. The cathedral was built by Prince Yaroslav the Wise and dedicated to the Holy Wisdom of God.', 'Route 1: Cultural capital of Lviv'),
(3, 'Crimean mountains', 'The Crimean Mountains, also known as the Crimean Alps, are a mountain range located on the Crimean Peninsula along the northern coast of the Black Sea. This mountainous region is characterized by diverse landscapes, including rocky cliffs, lush valleys, and densely forested areas. The highest peak in the Crimean Mountains is Roman-Kosh, standing at approximately 1,545 meters (5,069 feet) above sea level.', 'Route 2: Mountains and History of Crimea'),
(4, 'Khortytsia Island', 'Khortytsia is the largest river island in Europe, situated in the Dnipro River near the city of Zaporizhzhia, Ukraine. Rich in both natural beauty and historical significance, Khortytsia has played a crucial role in shaping the cultural and historical landscape of Ukraine.', 'Route 2: Mountains and History of Crimea'),
(5, 'Podilsk fortress', 'Kamianets-Podilskyi. Perched on a rock, Kamianets-Podilskyi Castle is an impressive fortress dating back to the 11th century. Over the centuries, it underwent various reconstructions, incorporating elements of different architectural styles. The castle is surrounded by the winding Smotrych River, enhancing its defensive capabilities. The complex includes towers, dungeons, and well-preserved walls, offering panoramic views of the picturesque surroundings. With its rich history and unique architectural features, Kamianets-Podilskyi Castle is a significant cultural and historical landmark in Ukraine.', 'Route 2: Mountains and History of Crimea'),
(6, 'Carpathians', 'Various villages in the Carpathian Mountains and the Poltava region. The Wooden Churches of the Carpathian Region in Ukraine are a collection of unique architectural masterpieces. Built without the use of nails, these churches are known for their exquisite wooden craftsmanship. Many of them date back to the 17th and 18th centuries and showcase a distinctive blend of folk and Gothic architectural styles. The churches are characterized by their tall spires, intricate wooden carvings, and vibrant, traditional paintings. Designated as UNESCO World Heritage Sites, these churches not only serve as religious institutions but also stand as testaments to the rich cultural and historical heritage of the Carpathian region. Each church reflects the artistry and skill of local craftsmen, making them a significant part of Ukraine`s cultural landscape.', 'Route 3: Castles and the Carpathians'),
(7, 'Radomysl Castle', 'Radomyshl, Zhytomyr Oblast, Ukraine. Radomysl Castle, also known as the Radomysl Castle and Museum Complex "Radomysl Castle," is an architectural gem located in the town of Radomyshl. Constructed in the late 19th century, the castle is a unique blend of romantic and neo-Gothic styles. It was the residence of the noble Polish family of Sanguszko and later underwent extensive restoration.', 'Route 3: Castles and the Carpathians'),
(8, 'Ostroh Academy', 'Ostroh, Rivne Oblast, Ukraine. Ostroh Academy, founded in 1576, is one of the oldest educational institutions in Eastern Europe. Situated in the historic town of Ostroh in the Rivne Oblast of Ukraine, the academy played a significant role in the cultural and educational development of the region. The architectural ensemble of Ostroh Academy is a remarkable example of Renaissance style.', 'Route 4: Cultural treasures of western Ukraine'),
(9, 'Church of St. George', 'Drohobych, Lviv Oblast, Ukraine. St. George`s Cathedral, also known as the Church of St. Yuriy, stands as a masterpiece of Gothic architecture dating back to the 15th century. The cathedral is an integral part of the Drohobych architectural ensemble and is recognized as a UNESCO World Heritage Site.', 'Route 4: Cultural treasures of western Ukraine'),
(10, 'Nesvytskyi Castle', 'Nesvizh Castle, Ternopil Oblast, Ukraine. Nesvizh Castle, located in the Ternopil Oblast of Ukraine, is a magnificent architectural gem with a rich history dating back to the 16th century. Also known as Niasvizh Castle, it is recognized as a UNESCO World Heritage Site.', 'Route 1: Cultural capital of Lviv');

-- Inserting data into the Routes table
INSERT INTO Routes (name, description, start_location, end_location) VALUES
('Route 1: Cultural capital of Lviv', 'Start your trip with a visit to the Lviv Opera, which is famous for its architecture and high-class performances. Move to Kyiv to visit Hagia Sophia, a historical monument dating back to the 11th century. Make your way to Ternopil Oblast to see Nesvytskyi Castle, a UNESCO World Heritage Site. Complete your itinerary with a visit to Ostroh Academy in Rivne Oblast, one of the oldest institutions of higher learning in Eastern Europe.', 1, 8),
('Route 2: Mountains and History of Crimea', 'Start your journey in the Crimean Mountains, enjoying breathtaking mountain scenery and natural beauty. Travel to Zaporozhye to visit the island of Khortytsia, which has great historical significance and is remembered for its nature conservation area. Head southwest to Akkermansk to visit Podilsk Fortress, a historic site and witness to a rich past. End your trip by visiting the Church of St. George, located in Kamianets-Podilskyi, famous for its architectural grandeur.', 2, 9),
('Route 3: Castles and the Carpathians', 'Start your journey from Radomysl Castle, which impresses with its architectural beauty and folklore traditions. Move to the Carpathians to enjoy mountain scenery, hiking trails and traditional villages. Return to Lviv to visit the Lviv Opera, perhaps taking with you new experiences from the trip.', 7, 1),
('Route 4: Cultural treasures of western Ukraine', 'Start with the Lviv Opera House, which is one of the city` cultural gems. Move to Kyiv to visit St. Sophia Cathedral, rich in history and architectural grandeur. Travel to Ostrog to see the Ostrog Academy, which plays an important role in the development of education in Ukraine. End your itinerary in Kamianets-Podilskyi by visiting the Church of St. George to enjoy the cultural heritage and architecture.', 1, 9);

-- Inserting data into the Establishments table
INSERT INTO Establishments (location_id, name, category, description, rating) VALUES
(1, 'Premier Palace Hotel', 'Hotel', 'Situated in the heart of the capital city, Premier Palace Hotel is a luxury landmark known for its exquisite architecture and opulent interiors. With a history dating back to the early 20th century, this hotel seamlessly combines historic charm with modern amenities, offering guests a luxurious and comfortable stay.', 4),
(2, '"Dnipro" Restaurant', 'Restaurant', 'Situated in the heart of Kyiv, "Dnipro" is an elegant restaurant offering a sophisticated dining experience. Known for its panoramic views of the Dnipro River, the restaurant specializes in Ukrainian and European cuisine, showcasing a blend of traditional flavors with modern culinary techniques.', 5),
(3, 'National Art Museum of Ukraine', 'Museum', 'The National Art Museum of Ukraine, located in the capital city Kyiv, houses an extensive collection of Ukrainian art spanning from ancient times to the present day. The museum showcases a diverse range of paintings, sculptures, decorative arts, and contemporary exhibits, providing a comprehensive overview of Ukraine`s rich artistic heritage.', 4),
(4, 'Hotel Bristol', 'Hotel', 'Overlooking the Black Sea, Hotel Bristol in Odessa is a symbol of elegance and sophistication. Built in the 19th century, this historic hotel has been meticulously preserved and offers a blend of classic charm and contemporary comfort. With its stunning sea views, refined dining options, and impeccable service, Hotel Bristol is a favorite among those seeking a luxurious retreat in the beautiful coastal city of Odessa.', 3),
(5, '"Osteria Pantagruel"', 'Restaurant', 'Located in the picturesque city of Lviv, "Osteria Pantagruel" is a charming Italian restaurant that has gained fame for its authentic Italian dishes. The warm and inviting atmosphere, coupled with a diverse menu featuring handmade pasta and flavorful antipasti, makes it a favorite among locals and visitors alike.', 4),
(6, 'Museum of the History of Ukraine', 'Museum', 'Situated in the heart of Kyiv, the Museum of the History of Ukraine offers a captivating journey through the nation`s past. Exhibits cover a wide range of historical periods, from ancient times to modern independence. Visitors can explore artifacts, documents, and interactive displays that highlight key events and developments in Ukrainian history.', 5),
(7, 'Fairmont Grand Hotel', 'Hotel', 'Nestled on the Dnipro River banks, the Fairmont Grand Hotel Kyiv is a five-star hotel that defines luxury in the Ukrainian capital. Boasting modern design and world-class amenities, it caters to the needs of discerning travelers. The hotel features elegant rooms, gourmet dining options, a spa, and breathtaking views of the city skyline. Its prime location provides easy access to Kyiv`s cultural and historical landmarks.', 3),
(8, '"Kanapa"', 'Restaurant', '"Kanapa" is a culinary gem nestled in the historic district of Kyiv. This restaurant is renowned for its commitment to Ukrainian gastronomic traditions, offering a menu inspired by local ingredients and ancient recipes. The cozy ambiance and artistic presentation of dishes contribute to a truly immersive dining experience.', 4),
(9, 'Lviv Historical Museum', 'Museum', 'The Lviv Historical Museum, located in the picturesque city of Lviv, is a treasury of historical artifacts reflecting the diverse cultural influences on the region. The museum`s exhibits include archaeological finds, medieval artifacts, and displays on the city`s architectural evolution. It serves as a captivating window into Lviv`s rich history.', 5),
(10, 'Bukovel Hotel', 'Hotel', 'For those seeking a mountain retreat, Bukovel Hotel in the Carpathian Mountains is a top choice. Known for being a part of the popular Bukovel ski resort, this hotel offers comfortable accommodations with stunning views of the surrounding mountains. In addition to its proximity to ski slopes, the hotel provides various recreational facilities, including spa services, making it a haven for both winter sports enthusiasts and those looking to unwind in a picturesque setting.', 4);

-- Inserting data into the Reviews table
INSERT INTO Reviews (user_id, poi_id, description, rating) VALUES
(1, 1, 'Premier Palace Hotel is a true gem in the heart of Kyiv. The historic charm and luxurious interiors make it a perfect blend of past and present.', 4),
(2, 2, 'Dnipro Restaurant offers a dining experience like no other. The panoramic views of the Dnipro River create a magical atmosphere, complemented by the elegant interior.', 5),
(3, 3, 'A cultural haven in Kyiv, the National Art Museum of Ukraine is a treasure trove of artistic expression. The diverse collection provides insight into Ukraine`s rich heritage.', 3),
(4, 4, 'Hotel Bristol in Odessa is a timeless beauty overlooking the Black Sea. The historic charm is evident in every detail, from the elegant architecture to the impeccable service.', 4),
(5, 5, 'Osteria Pantagruel in Lviv is a culinary delight for lovers of authentic Italian cuisine. The handmade pasta and flavorful dishes transport you to Italy.', 5),
(6, 6, 'The Museum of the History of Ukraine in Kyiv is a captivating journey through time. The exhibits are well-curated, providing a comprehensive overview of Ukraine`s rich history.', 3),
(7, 7, 'Fairmont Grand Hotel Kyiv offers a luxurious escape on the banks of the Dnipro River. The modern design, upscale amenities, and breathtaking views make it a top choice for a sophisticated stay.', 4),
(8, 8, 'Kanapa is a culinary gem in Kyiv, celebrating the richness of Ukrainian gastronomy. The menu, inspired by local ingredients and ancient recipes, is a testament to the restaurant`s commitment to authenticity.', 5),
(9, 9, 'The Lviv Historical Museum is a captivating journey through the city`s past. The exhibits, ranging from archaeological finds to medieval artifacts, offer a comprehensive view of Lviv`s diverse history.', 3),
(10, 10, 'Bukovel Hotel in the Carpathian Mountains is a perfect retreat for those seeking a mountain escape. The proximity to the ski resort and recreational facilities make it an ideal choice for winter sports enthusiasts.', 4);
