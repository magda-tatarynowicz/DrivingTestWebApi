using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
using Data.Repositories.Interfaces;

namespace Data.Repositories
{
    public class QuestionsRepository : BaseRepository, IQuestionsRepository
    {
        public QuestionsRepository(DrivingTestContext context) : base(context)
        {
        }

        public void AddAdvancedQuestion(AdvancedQuestion question)
        {
            Context.AdvancedQuestionsDbSet.Add(question);
        }

        public void AddBasicQuestion(BasicQuestion question)
        {
            Context.BasicQuestionsDbSet.Add(question);
        }

        public void AddQuestionsWithPicture()
        {
            var webClient = new WebClient();

            Context.Questions.AddBasicQuestion(new BasicQuestion
            {
                IsVerified = true,
                IsCorrect = true,
                Points = 2,
                QuestionString = "Czy w przedstawionej sytuacji jesteś ostrzegany o poprzecznej nierówności jezdni?",
                PhotoString = Convert.ToBase64String(webClient.DownloadData("http://mib.gov.pl/media/pj/media/IMG_9274d8org.jpg"))
            });

            /*Context.Questions.AddBasicQuestion(new BasicQuestion
            {
                IsVerified = true,
                IsCorrect = false,
                Points = 1,
                QuestionString = "Czy w przedstawionej sytuacji jesteś ostrzegany o przejeździe kolejowym wyposażonym w półzapory?",
                PhotoString = Convert.ToBase64String(webClient.DownloadData("http://mib.gov.pl/media/pj/media/1070D18org.jpg"))
            });

            Context.Questions.AddBasicQuestion(new BasicQuestion
            {
                IsVerified = true,
                IsCorrect = true,
                Points = 3,
                QuestionString = "Czy w przedstawionej sytuacji jesteś ostrzegany o zwężeniu jezdni, które może powodować utrudnienia ruchu?",
                PhotoString = Convert.ToBase64String(webClient.DownloadData("http://mib.gov.pl/media/pj/media/IMG_0816d8org.jpg"))
            });*/

            Context.Questions.AddBasicQuestion(new BasicQuestion
            {
                IsVerified = true,
                IsCorrect = false,
                Points = 3,
                QuestionString = "Czy ten znak oznacza, że dzieci przeprowadzane są w tym miejscu przez jezdnię przez uprawnioną osobę?",
                PhotoString = Convert.ToBase64String(webClient.DownloadData("http://mib.gov.pl/media/pj/media/046TRAM3org.jpg"))
            });

           /*Context.Questions.AddBasicQuestion(new BasicQuestion
            {
                IsVerified = true,
                IsCorrect = true,
                Points = 3,
                QuestionString = "Czy widząc ten znak jesteś ostrzegany o zbliżaniu się do miejsca szczególnie uczęszczanego przez dzieci?",
                PhotoString = Convert.ToBase64String(webClient.DownloadData("http://mib.gov.pl/media/pj/media/112TRAM1org.jpg"))
            });*/

           Context.Questions.AddBasicQuestion(new BasicQuestion
            {
                IsVerified = true,
                IsCorrect = false,
                Points = 1,
                QuestionString = "Czy możesz skorzystać z tej drogi, chcąc wjechać do myjni?",
                PhotoString = Convert.ToBase64String(webClient.DownloadData("http://mib.gov.pl/media/pj/media/IMG_0004borg.jpg"))
            });


            Context.Questions.AddBasicQuestion(new BasicQuestion
            {
                IsVerified = true,
                IsCorrect = true,
                Points = 2,
                QuestionString = "Czy kierujący samochodem osobowym powinien mieć przy sobie dokument stwierdzający dopuszczenie pojazdu do ruchu? "
            });

            Context.Questions.AddBasicQuestion(new BasicQuestion
            {
                IsVerified = true,
                IsCorrect = true,
                Points = 3,
                QuestionString = "Czy kierujący samochodem osobowym powinien mieć przy sobie prawo jazdy?"
            });

            Context.Questions.AddBasicQuestion(new BasicQuestion
            {
                IsVerified = true,
                IsCorrect = true,
                Points = 3,
                QuestionString = "Czy kierującemu samochodem osobowym nie wolno przewozić na przednim siedzeniu dziecka w wieku do 12 lat (bez specjalnego fotelika)?"
            });

            Context.Questions.AddBasicQuestion(new BasicQuestion
            {
                IsVerified = true,
                IsCorrect = true,
                Points = 3,
                QuestionString = "Czy pozycja boczna ustalona jest dla pacjenta bezpieczna, ponieważ: jest stabilna, zabezpiecza przed zachłyśnięciem oraz zapewnia drożność dróg oddechowych?"
            });

            Context.Questions.AddAdvancedQuestion(new AdvancedQuestion
            {
                IsVerified = true,
                QuestionString = "Jak długo należy prowadzić uciskanie klatki piersiowej i sztuczne oddychanie u osoby z nagłym zatrzymaniem krążenia?",
                Points = 3,
                CorrectAnswer = 0,
                AnswerA = "Do momentu przyjazdu zespołu ratownictwa medycznego.",
                AnswerB = "Przez 15 minut.",
                AnswerC = "Dopóki ciało poszkodowanego zachowuje właściwą ciepłotę",
                PhotoString = Convert.ToBase64String(webClient.DownloadData("http://mib.gov.pl/media/pj/media/R_144org.jpg"))
            });


            Context.Questions.AddAdvancedQuestion(new AdvancedQuestion
            {
                IsVerified = true,
                QuestionString = "Z jaką maksymalną dopuszczalną prędkością wolno Ci kierować samochodem osobowym po drodze za tym znakiem?",
                Points = 2,
                CorrectAnswer = 0,
                AnswerA = "20 km/h",
                AnswerB = "30 km/h",
                AnswerC = "50 km/h",
                PhotoString = Convert.ToBase64String(webClient.DownloadData("http://mib.gov.pl/media/pj/media/3475D15orgbm.jpg")),
                Theory = "W obszarze zamieszkania można kierować z prędkością maksymalną 20 km/h."
            });

            Context.Questions.AddAdvancedQuestion(new AdvancedQuestion
            {
                IsVerified = true,
                QuestionString = "Który czynnik ma zasadniczy wpływ na bezpieczeństwo, gdy wymijasz inny pojazd?",
                Points = 3,
                CorrectAnswer = 2,
                AnswerA = "Prawidłowe ułożenie rąk na kierownicy.",
                AnswerB = "Pojazdy jadące za tobą.",
                AnswerC = "Zachowanie bezpiecznego odstępu."
            });

            Context.Questions.AddAdvancedQuestion(new AdvancedQuestion
            {
                IsVerified = true,
                QuestionString = "Którą z wymienionych służb powiadomisz, aby podjęła akcję ratowniczą, polegającą na neutralizacji substancji niebezpiecznej na drodze?",
                Points = 3,
                CorrectAnswer = 2,
                AnswerA = "Policję",
                AnswerB = "Inspekcję Transportu Drogowego",
                AnswerC = "Państwową straż pożarną"
            });

            Context.Questions.AddAdvancedQuestion(new AdvancedQuestion
            {
                IsVerified = true,
                QuestionString = "Który bieg jest właściwy do rozpoczęcia jazdy samochodem osobowym na suchej nawierzchni?",
                Points = 3,
                CorrectAnswer = 1,
                AnswerA = "Drugi",
                AnswerB = "Pierwszy",
                AnswerC = "Ten, na którym jazda została zakończona"
            });

        }

        public void AddSampleQuestions()
        {
            Context.Questions.AddBasicQuestion(new BasicQuestion
            {
                IsVerified = true,
                IsCorrect = true,
                Points = 3,
                QuestionString = "Czy w tej sytuacji powinieneś oczekiwać, że następnym sygnałem będzie światło zielone?"
            });

            Context.Questions.AddBasicQuestion(new BasicQuestion
            {
                IsVerified = true,
                IsCorrect = true,
                Points = 3,
                QuestionString = "Czy w tej sytuacji zabroniony jest Twój wjazd na skrzyżowanie?"
            });

            Context.Questions.AddBasicQuestion(new BasicQuestion
            {
                IsVerified = true,
                IsCorrect = true,
                Points = 3,
                QuestionString = "Czy w tej sytuacji znajdujesz się na jezdni dwukierunkowej?"
            });

            Context.Questions.AddBasicQuestion(new BasicQuestion
            {
                IsVerified = true,
                IsCorrect = false,
                Points = 3,
                QuestionString = "Test niezweryfikowanego"
            });

            Context.Questions.AddAdvancedQuestion(new AdvancedQuestion
            {
                IsVerified = true,
                QuestionString = "Czego możesz spodziewać się wjeżdżając na most oznaczony tym znakiem ?",
                Points = 1,
                CorrectAnswer = 2,
                AnswerA = "Zalegającego śniegu i zasp",
                AnswerB = "Obfitych opadów śniegu",
                AnswerC = "Oszronienia jezdni lub gołoledzi, nawet jeśli nie występują na innych odcinkach drogi"
            });

            Context.Questions.AddAdvancedQuestion(new AdvancedQuestion
            {
                IsVerified = false,
                QuestionString = "Test niezweryfikowanego jeszcze raz",
                Points = 1,
                CorrectAnswer = 2,
                AnswerA = "Zalegającego śniegu i zasp",
                AnswerB = "Obfitych opadów śniegu",
                AnswerC = "Oszronienia jezdni lub gołoledzi, nawet jeśli nie występują na innych odcinkach drogi"

            });

        }

        public IList<AdvancedQuestion> GetAllVerifiedAdvancedQuestions()
        {
            return Context.AdvancedQuestionsDbSet.Where(q => q.IsVerified).ToList();
        }

        public IList<BasicQuestion> GetAllVerifiedBasicQuestions()
        {
            return Context.BasicQuestionsDbSet.Where(q => q.IsVerified).ToList();
        }

        public IList<Question> GetAllVerifiedQuestions()
        { 
            return GetAllVerifiedBasicQuestions().Cast<Question>().Concat(GetAllVerifiedAdvancedQuestions().Cast<Question>()).ToList();
        }

        public IList<AdvancedQuestion> GetAllNotVerifiedAdvancedQuestions()
        {
            return Context.AdvancedQuestionsDbSet.Where(q => !q.IsVerified).ToList();
        }

        public IList<BasicQuestion> GetAllNotVerifiedBasicQuestions()
        {
            return Context.BasicQuestionsDbSet.Where(q => !q.IsVerified).ToList();
        }

        public IList<Question> GetAllNotVerifiedQuestions()
        {
            return GetAllNotVerifiedBasicQuestions().Cast<Question>().Concat(GetAllNotVerifiedAdvancedQuestions().Cast<Question>()).ToList();
        } 

        public void RemoveAllQuestions()
        {

        }

        public void VerifyQuestion(int questionId)
        {
            var basicQuestion = Context.BasicQuestionsDbSet.SingleOrDefault(q => q.Id == questionId);
            var advancedQuestion  = Context.AdvancedQuestionsDbSet.SingleOrDefault(q => q.Id == questionId);
            if (basicQuestion != null)
                basicQuestion.IsVerified = true;
            else if (advancedQuestion != null)
                advancedQuestion.IsVerified = true;
        }

        public void RemoveQuestion(int id)
        {
            if(Context.BasicQuestionsDbSet.SingleOrDefault(q => q.Id == id)!=null)
                Context.BasicQuestionsDbSet.Remove(Context.BasicQuestionsDbSet.SingleOrDefault(q => q.Id == id));
            else if (Context.AdvancedQuestionsDbSet.SingleOrDefault(q => q.Id == id) != null)
                Context.AdvancedQuestionsDbSet.Remove(Context.AdvancedQuestionsDbSet.SingleOrDefault(q => q.Id == id));
        }
    }
}
