using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeeding2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Written by India’s first prime minister when  he was in prison (1942-1946), this book traces India’s   history starting from the Indus Valley Civilization. It   gives a detailed account of the period ranging from the   coming of the Aryans to the establishment of the British  Empire. A recommended read to get a snapshot of India’s  incredibly long past. This book was also produced as an  award-winning television series by Shyam Benegal.", "https://m.media-amazon.com/images/I/51JTJUe0-    +L._SX343_BO1,204,203,200_.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Title" },
                values: new object[] { "This book primarily focuses on India’s   independence        movement during 1946 and 1948. The    series of events that   unfold  during  this period are    worthy of this book being     classified as a    historical        one. It is extensively    researched, gives incredible        details that you    never knew    (for instance, do you     know who   actually drew the dividing    line between the   two nations and on  what basis?) and is a   highly    recommended book on India’s    independence and   partition.   The book also    includes interviews   with Lord     Mountbatten, the last viceroy of British     India.", "https://m.media-amazon.com/images/          I/51Frw6rTpGL._SX322_BO1,204,203,200_.jpg", "Freedom at Midnight by Dominique Lapierre and Larry      Collins" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Written by the Nobel Prize winning economist Amartya Sen, this book is essentially a series of poignant essays narrating India’s history and how that history has influenced and shaped its cultural identity. Sen talks about how India has had a long history of public debate (in all spheres of life) and how heterodoxy was prevalent in Indian society centuries ago. This vibrant past is something that Sen believes we all should know about – considering that it can have a deep impact on the way we embrace our future.", " https://m.media-amazon.com/images/I/61lVEuWnW8L._SX325_BO1,204,203,200_.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "This book is considered a useful source of history for aspirants to the Indian civil services. Basham’s popular work covers the period between ancient India and the arrival of the Muslims. It covers details of the Harappan and Mohenjodaro findings and then dwells on the now-controversial Aryan invasion theory. Basham also studies the interpretations of the Rig Veda and other Sanskrit texts to give a better understanding of the country’s past.", " https://m.media-amazon.com/images/I/41CTXwZtZAL._SX329_BO1,204,203,200_.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "John Keay is an English journalist and author specialising in writing popular histories about India, often with a particular focus on their colonisation and exploration by Europeans. In “India: A history”, John provides a panaromic view starting from the cities of Harappa and Mohenjodaro of the Indus Valley civilizations all the way to the current modern India. This book is considered by many as a perfect textbook for any student of India.", " https://m.media-amazon.com/images/I/51ylP4+2y2L._SX327_BO1,204,203,200_.jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Written by India’s first prime minister when    he was in prison (1942-1946), this book traces India’s     history starting from the Indus Valley Civilization. It     gives a detailed account of the period ranging from the     coming of the Aryans to the establishment of the British    Empire. A recommended read to get a snapshot of India’s    incredibly long past. This book was also produced as an    award-winning television series by Shyam Benegal.", "https://m.media-amazon.com/images/I/51JTJUe0-+L._SX343_BO1,204,203,200_.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Title" },
                values: new object[] { "This book primarily focuses on India’s   independence  movement during 1946 and 1948. The series of    events that unfold  during this period are worthy of this  book being classified as a  historical one. It is    extensively researched, gives incredible  details that you     never knew (for instance, do you know who   actually drew   the dividing line between the two nations and on    what  basis?) and is a highly recommended book on India’s      independence and partition. The book also includes     interviews     with Lord Mountbatten, the last viceroy of   British India.", "https://m.media-amazon.com/images/I/51Frw6rTpGL._SX322_BO1,204,203,200_.jpg", "Freedom at Midnight by Dominique Lapierre and Larry Collins" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Written by the Nobel Prize winning economist       Amartya Sen, this book is essentially a series of poignant    essays narrating India’s history and how that history has      influenced and shaped its cultural identity. Sen talks     about how    India has had a long history of public debate  (in all spheres     of life) and how heterodoxy was  prevalent in Indian society     centuries ago.  This vibrant  past is something that Sen believes     we all should know  about – considering that it can have a deep     impact on    the way we embrace our future.", "	https://m.media-amazon.com/images/I/61lVEuWnW8L._SX325_BO1,204,203,200_.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "This book is considered a useful source of   history   for aspirants to the Indian civil services.     Basham’s popular  work covers the period between ancient    India and the arrival of  the Muslims. It covers details of    the Harappan and Mohenjodaro   findings and then dwells on     the now-controversial Aryan invasion   theory. Basham also  studies the interpretations of the Rig Veda   and other  Sanskrit texts to give a better understanding of the     country’s past.", "	https://m.media-amazon.com/images/I/41CTXwZtZAL._SX329_BO1,204,203,200_.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "John Keay is an English journalist and author specialising in writing popular histories about India,  often   with a particular focus on their colonisation and exploration by   Europeans. In “India: A history”, John    provides a panaromic  view starting from the cities of     Harappa and Mohenjodaro of the  Indus Valley civilizations  all the way to the current modern     India. This book is    considered by many as a perfect textbook for     any student    of India.", "	https://m.media-amazon.com/images/I/51ylP4+2y2L._SX327_BO1,204,203,200_.jpg" });
        }
    }
}
