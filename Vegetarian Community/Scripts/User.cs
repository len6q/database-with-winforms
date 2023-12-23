namespace Vegetarian_Community.Scripts
{
    public sealed class User
    {
        /// <summary>
        /// Класс пользователя
        /// </summary>
        /// <param name="currentId">Уникальный идентификатор пользователя</param>
        /// <param name="name">Имя пользователя</param>
        /// <param name="sex">Пол пользователя</param>
        /// <param name="age">Возраст пользователя</param>
        public User(int currentId, string name, string sex, int age)
        {
            Id = currentId;
            Name = name;
            Sex = sex;
            Age = age;
        }

        /// <summary>
        /// Уникальный идентификатор пользователя
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Пол пользователя
        /// </summary>
        public string Sex { get; }

        /// <summary>
        /// Возраст пользователя
        /// </summary>
        public int Age { get; }
    }
}
