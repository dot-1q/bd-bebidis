using System;
using System.Collections.Generic;
using System.Text;

namespace Bebidis
{
    public class FormProvider
    {
        public static Login MainMenu
        {
            get
            {
                if (_mainMenu == null)
                {
                    _mainMenu = new Login();
                }
                return _mainMenu;
            }
        }
        private static Login _mainMenu;
    }
}
