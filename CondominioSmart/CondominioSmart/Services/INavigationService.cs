using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CondominioSmart.Services
{
    public interface INavigationService
    {
        Task NavigationForLogin();
        Task NavigationForMenu();
        Task NavigationForPopUpCheckOk();
        Task NavigationForPopUpLoadPage(string titulo, string mensagem);
        Task NavigationForPopUpPage();
        Task NavigationForReclamacoesPage();
        Task NavigationForInformacoesPage();
        Task NavigationForPopPage();
        Task NavigationForAtendimentosPage();
        Task NavigationForPortariaPage();
        Task NavigationForReclamacaoTabbedPagePage();
    }
}
