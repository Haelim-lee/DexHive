using DexHive;
using DexHive.사용자관리UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DexHive
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //1.윈폼준비 렌더링 기본코드
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //2.데이터베이스 및 로그인창 객체 생성
            서비스_클라이언트 WCF서버 = new 서비스_클라이언트();//WCF서버
            로그인화면 로그인 = new 로그인화면();


            //3.로그인화면 실행
            로그인.서비스 = WCF서버.서비스;
            DialogResult 성공여부 = 로그인.ShowDialog();

            //4.로그인 성공시 메인화면 실행
            앤츠네스트 메인화면 = new 앤츠네스트();
            메인화면.서비스 = WCF서버.서비스;
            if (성공여부 == DialogResult.OK) Application.Run(메인화면);

            //5.프로그램 종료시 통신도 종료
            ((ICommunicationObject)WCF서버.서비스).Close();
        }
    }
}
