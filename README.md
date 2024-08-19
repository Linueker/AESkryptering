AES-kryptering av meddelanden. 
Olika brancher har lite olika lösningar, framför allt vad gäller databashantering.
- Main-branchen använder SQLite och skapar en lokal databasfil i projektet. För att kunna öppna databasfilen krävs en SQLite databashanterare, borde vara lätt att hitta.
- Linus-branchen använder Entity Framework core och MS-SQL server. Där behövs en ändring av connection string då den nuvarande leder till Linus lokala databas
- TimTestDB använder även den en lokal databas endast lite annorlunda från Linus-branchen. 
