namespace Sealed_Struct_Nullable_Enum
{
    internal sealed class Book
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public Author? Author { get; set; }
    }
}
