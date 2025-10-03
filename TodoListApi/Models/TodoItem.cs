using TodoListApi.Enums;

namespace TodoListApi.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public EnumConcluidoPendente Status { get; set; }
    }
}
