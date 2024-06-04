namespace Models
{
    public class Item
    {
        public readonly static string INSERT = "INSERT INTO TB_ITEM (DESCRIPTION_ITEM) VALUES (@DESCRIPTION); SELECT * FROM TB_ITEM";
        public int Id { get; set; }
        public string? Description { get; set; }
    }
}
