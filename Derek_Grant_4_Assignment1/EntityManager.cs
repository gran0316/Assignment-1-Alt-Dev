D e v e l o p m e n t \ A s s i g n m e n t s \ D e r e k _ G r a n t _ 4 _ A s s i g n m e n t 1 \ D e r e k _ G r a n t _ 4 _ A s s i g n m e n t 1 \ R e c t a n g l e S t r u c t . c s �j��E��/_�g
����������������                                                                                                                                                                                                                                                                                              O u t l i n i n g S t a t e E x 1 2                             & .      ����                                    �   N      O u t l i n i n g S t a t e E x 7                               $ *   /   ����                                    �   6                                                                          ������������
E:\School\Fall 2012\Alternative Development\Assignments\Derek_Grant_4_Assignment1\Derek_Grant_4_Assignment1\obj\x86\Debug\Derek_Grant_4_Assignment1.exe
E:\School\Fall 2012\Alternative Development\Assignments\Derek_Grant_4_Assignment1\Derek_Grant_4_Assignment1\obj\x86\Debug\ResolveAssemblyReference.cache
H:\School\Fall 2012\Alternative Development\Assignments\Derek_Grant_4_Assignment1\Derek_Grant_4_Assignment1\obj\x86\Debug\Derek_Grant_4_Assignment1.exe
                                                                                                                                                (int i = 0; i < _maxEntities; i++)
            {
                if (entArray.Equals(entity) == true)
                {
                    entArray[i] = null;
                }
            }
        }

        public virtual GameEntity GetEntity(string name)
        {
            int count = 0;
            bool found = false;
            for (int i = 0; i < _maxEntities; i++)
            {
                if (entArray[i].Name == name)
                {
                    count = 1;
                    break;
                }
            }
            if (!found)
                return null;

            return entArray[count];
        }
        

        public virtual GameEntity GetEntity(int id)
        {
            int count = 0;
            bool found = false;
            for (int i = 0; i < _maxEntities; i++)
            {
                if (entArray[i].ID == id)
                {
                    count = 1;
                    break;
                }
            }
            if (!found)
                return null;

            return entArray[count];
        }

        public void PrintAllEntities()
        {
            for (int i = 0; i < _maxEntities; i++)
            {
                entArray[i].ToString();
            }
        }
        #endregion


    }
}
