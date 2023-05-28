using System.Collections;

namespace _06_propias_dictionarybase
{
    internal class ColeccionProfesores:System.Collections.DictionaryBase
    {
        public void Add(string key, Profesor value)
        {
            InnerHashtable.Add(key, value); //no se ejecutan OnInsert y OnInsertComplete
            //Dictionary.Add(key, value);
        }
        public ICollection Keys
        {
            get
            {
                return Dictionary.Keys;
            }          
        }

        public Profesor this[string key]
        {
            get
            {
                return (Profesor)Dictionary[key];
            }
            set { 
                Dictionary[key] = value;
            }
        }

        //public Profesor Get(string key)
        //{
        //    return Dictionary.Keys[key];
        //}

        protected override void OnInsert(object key, object? value)
        {
            base.OnInsert(key, value);
            Console.WriteLine($">> OnInsert:Key {key}");
        }

        protected override void OnInsertComplete(object key, object? value)
        {
            base.OnInsertComplete(key, value);
            Console.WriteLine($">> OnInsertComplete:Key {key}");
        }
    }
}
