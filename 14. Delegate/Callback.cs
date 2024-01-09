using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._Delegate
{
    internal class Callback
    {
        /*******************************************************************************
         * 콜백함수
         * 
         * 델리게이트를 이용하여 특정조건에서 반응하는 함수를 구현
         * 함수의 호출(Call)이 아닌 역으로 호출받을 때 반응을 참조하여 역호출(Callback)
         *******************************************************************************/

        void Main()
        {
            Button mainmenuBtn = new Button(MainMenu);
            Button settingBtn = new Button(Setting);
            Button continueBtn = new Button(Continue);

            mainmenuBtn.Click();    // output : 메뉴창을 엽니다.
            settingBtn.Click();     // output : 설정창을 엽니다.
            continueBtn.Click();    // output : 계속 진행합니다.
        }

        class Button
        {
            Action callback;

            public Button(Action callback)
            {
                this.callback = callback;
            }

            public void Click()
            {
                if (callback != null)
                    callback();
            }
        }

        void MainMenu() { Console.WriteLine("메뉴창을 엽니다."); }
        void Setting() { Console.WriteLine("설정창을 엽니다."); }
        void Continue() { Console.WriteLine("계속 진행합니다."); }
    }
}
