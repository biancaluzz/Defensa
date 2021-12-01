namespace Ucu.Poo.Defense
{
    public class Material
    {
        MaterialType dangerousType;
        MaterialType nonDangerousType;
        public string Name { get; set; }

        public MaterialType Type { get; set; }

        public Material(string name, MaterialType type)
        {
            this.Name = name;
            this.Type = type;
        }

        public string IsDangerous(MaterialType type)
        {
            if (type.IsDangerous == false)
            {
                return type.IsDangerous = nonDangerousType;
            }
            else
            {
                return type.IsDangerous = dangerousType;
            }
        }
    }
}