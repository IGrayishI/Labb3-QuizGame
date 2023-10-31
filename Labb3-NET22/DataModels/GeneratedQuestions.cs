using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Labb3_NET22.DataModels
{
    internal  class GeneratedQuestions
    {
        public  List<Question> allQuestions = new List<Question>()
        {
            new Question("Science", "Which gas is most abundant in the Earth's atmosphere?", 2, "https://www.snexplores.org/wp-content/uploads/2020/11/1030_Earth_atmosphere_explainer.jpg", new string[] { "Oxygen", "Nitrogen", "Carbon Dioxide", "Hydrogen" }),
            new Question("Science", "What is the chemical symbol for water?", 1, "https://domf5oio6qrcr.cloudfront.net/medialibrary/7909/conversions/b8a1309a-ba53-48c7-bca3-9c36aab2338a-thumb.jpg", new string[] { "H2O", "CO2", "O2", "NaCl" }),
            new Question("Science", "What is the chemical symbol for gold?", 1, "https://www.kitco.com/news/2023-03-13/images/shutterstock_2085345001-min.jpg", new string[] { "Au", "Ag", "Fe", "Cu" }),
            new Question("Science", "What is the chemical symbol for carbon?", 3, "https://www.foronuclear.org/wp-content/uploads/2010/06/carbon-854x465.jpg?x67659", new string[] { "Co", "Cr", "C", "Ca" }),
            new Question("Science", "Which gas do plants absorb from the atmosphere during photosynthesis?", 3, "https://media.npr.org/assets/img/2017/06/02/istock-500593292-1bb78a1e79717b7a2ac14dc9edf99cc71723d261-s1100-c50.jpg", new string[] { "Oxygen", "Nitrogen", "Carbon Dioxide", "Hydrogen" }),
            new Question("Geography", "What is the capital of France?", 3, "https://www.state.gov/wp-content/uploads/2023/07/shutterstock_667548661v2.jpg", new string[] { "London", "Berlin", "Paris", "Madrid" }),
            new Question("Geography", "Which country is known as the Land of the Rising Sun?", 3, "https://www.kuvo.org/wp-content/uploads/2021/10/LAND-OF-THE-RISING-SUN.jpg", new string[] { "China", "South Korea", "Japan", "Thailand" }),
            new Question("Geography", "Which continent is the largest by land area?", 1, "https://ichef.bbci.co.uk/images/ic/448xn/p070bqpj.jpg", new string[] { "Asia", "Africa", "North America", "Europe" }),
            new Question("Geography", "Which ocean is the largest on Earth?", 4, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTUTHVpCsCMdzXdXv6og2B0Oezv55UhOzbnHILvgOb524z_68dOCW3nY5UZMXZI1ICuunQ&usqp=CAU", new string[] { "Atlantic Ocean", "Indian Ocean", "Arctic Ocean", "Pacific Ocean" }),
            new Question("Geography", "Which desert is the largest in the world?", 1, "https://images.nationalgeographic.org/image/upload/v1638890138/EducationHub/photos/seba-oasis.jpg", new string[] { "Sahara Desert", "Gobi Desert", "Kalahari Desert", "Atacama Desert" }),
            new Question("History", "In which year did the Titanic sink?", 2, "https://hips.hearstapps.com/hmg-prod/images/this-terrible-scene-painted-by-german-artist-willy-stoewer-news-photo-517357578-1545065377.jpg?crop=1xw:0.82146xh;center,top&resize=1200:*", new string[] { "1910", "1912", "1915", "1917" }),
            new Question("History", "Who was the first woman to fly solo across the Atlantic Ocean?", 1, "https://img.freepik.com/premium-photo/airplane-flying-sky-passenger-airline-travel-tourism_31965-65077.jpg", new string[] { "Amelia Earhart", "Bessie Coleman", "Harriet Quimby", "Jacqueline Cochran" }),
            new Question("History", "Who was the first Emperor of the Roman Empire?",   2, "https://image.jimcdn.com/app/cms/image/transf/dimension=2080x10000:format=jpg/path/s2217cd0bb1220415/image/idc34b1b04f8e96ed/version/1687833802/how-big-was-the-roman-empire.jpg", new string[] { "Julius Caesar", "Augustus", "Nero", "Caligula" } ),
            new Question("History", "In which year did Sweden join the European Union (EU)?", 1, "https://schengenvisum.info/wp-content/uploads/2023/01/EU-kaart.jpg", new string[] { "1995", "1973", "2004", "2010" }),
            new Question("History", "In which year did World War I begin?", 1, "https://www.forces.net/sites/default/files/World%20War%20One%20British%20soldiers%20in%20a%20trench%20at%20the%20western%20front%20in%20France%20CREDIT%20PA.jpg", new string[] { "1914", "1916", "1918", "1920" }),
            new Question("History", "Which event is considered the immediate cause of World War I?", 1, "https://upload.wikimedia.org/wikipedia/en/thumb/2/2d/Britain_declares_war--Daily_Mail_Aug_5%2C_1914.jpg/640px-Britain_declares_war--Daily_Mail_Aug_5%2C_1914.jpg", new string[] { "Assassination of Archduke Franz Ferdinand", "Sinking of the Lusitania", "Treaty of Versailles", "Russian Revolution" }),
            new Question("History", "Which countries made up the Triple Entente in World War I?", 1, "https://www.historydefined.net/wp-content/uploads/2022/09/243770176_1039718433513087_933573196279888663_n-1-932x1024.jpg", new string[] { "France, United Kingdom, Russia", "Germany, Austria-Hungary, Ottoman Empire", "Italy, United States, Japan", "France, Germany, United Kingdom" }),
            new Question("History", "What was the main weapon used in the trenches of World War I?", 1, "https://img.thedailybeast.com/image/upload/c_crop,d_placeholder_euli9k,h_1439,w_2560,x_0,y_0/dpr_2.0/c_limit,w_740/fl_lossy,q_auto/v1492784491/articles/2013/05/22/the-utterly-pointless-first-world-war/130521-bishop-ww1-tease_hfvcx9", new string[] { "Machine Guns", "Tanks", "Flamethrowers", "Poison Gas" }),
            new Question("History", "Who is known as the 'Father of Modern Sweden'?",3, "https://366e203a.rocketcdn.me/wp-content/uploads/2022/07/Escape-In-Beautiful-Stockholm-%E2%80%93-A-Trip-To-Sweden.jpg", new string[] { "Gustav II Adolph", "Charles XII", "Gustav Vasa", "Carl XVI Gustaf" }),
            new Question("History", "What historical event marked the end of Sweden's reign as a great power in Europe during the early 18th century?", 2, "https://ih1.redbubble.net/image.4750376437.5221/flat,750x,075,f-pad,750x1000,f8f8f8.jpg", new string[] { "Great Northern War", "Battle of Poltava", "Treaty of Roskilde.", "Treaty of Nystad" }),
           
            new Question("Literature", "Who wrote the novel 'To Kill a Mockingbird'?", 3, "https://ncte.org/wp-content/uploads/2017/11/TKAMB-header.jpg", new string[] { "George Orwell", "Mark Twain", "Harper Lee", "J.K. Rowling" }),
            new Question("Literature", "Which novel features the characters Sherlock Holmes and Dr. John Watson?", 3, "https://studybreaks.com/wp-content/uploads/2021/08/The-Legacy-of-Sherlock-Holmes.jpg", new string[] { "Moby-Dick", "Dracula", "The Hound of the Baskervilles", "War and Peace" }),
            new Question("Literature", "In 'The Lord of the Rings,' who is the main protagonist?", 3, "https://static.independent.co.uk/s3fs-public/thumbnails/image/2016/02/09/10/the-lord-of-the-rings.jpg", new string[] { "Gandalf", "Aragorn", "Frodo Baggins", "Legolas" }),
            new Question("Literature", "Who wrote the novel '1984'?", 1, "https://media.comicbook.com/2021/01/george-orwell-1984-tv-show-wiip-1252214.jpeg?auto=webp", new string[] { "George Orwell", "Aldous Huxley", "Ray Bradbury", "F. Scott Fitzgerald" }),
            new Question("Mathematics", "What is the value of Pi (π) to two decimal places?", 1, "https://media.wired.co.uk/photos/606d9e1d581351b2c44d796c/4:3/w_6864,h_5148,c_limit/gettyimages-875606854.jpg", new string[] { "3.14", "3.141", "3.1416", "3.14159" }),
            new Question("Mathematics", "What is the square of 9?", 2, "https://images.slideplayer.com/12/3545838/slides/slide_15.jpg", new string[] { "64", "81", "49", "100" }),
            new Question("Mathematics", "What is the result of 5 multiplied by 7?", 2, "https://www.photographyaxis.com/wp-content/uploads/How-Big-is-a-5x7-Photo-1.jpg", new string[] { "30", "35", "42", "25" }),
            new Question("Mathematics", "What is the square root of 16?", 2, "https://arc-anglerfish-arc2-prod-tronc.s3.amazonaws.com/public/4VMI44RMAZDIXAIWQTFIGDLVUM.jpg", new string[] { "2", "4", "8", "16" }),

        };
    }
}
