AES-kryptering av meddelanden. 
Olika brancher har lite olika lösningar, framför allt vad gäller databashantering.
- Main-branchen använder SQLite och skapar en lokal databasfil i projektet.
- Linus-branchen använder Entity Framework core och MS-SQL server. Där behövs en ändring av connection string då den nuvarande leder till Linus lokala databas
- TimTestDB använder även den en lokal databas endast lite annorlunda från Linus-branchen. 
