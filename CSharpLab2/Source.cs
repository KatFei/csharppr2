#define TRACE 
using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Xml.Serialization;
//using System.Text.Encoding.CodePages;

namespace CSharpLab2
{
    /// <summary>
    /// Абстрактный класс <c>Source</c> - базовый класс для различных типов литературных 
    /// источников.
    /// </summary>
    /// <remarks>
    /// Содержит абстрактный метод <c>GetPublicationInfo()</c> и 
    /// абстрактное свойство <c>Author</c>, которые необходимо реализовать 
    /// в классах-наследниках.
    /// </remarks>
    [Serializable]
    public abstract class Source
    {
        /// <summary>
        /// Абстрактное свойство <c>Author</c> позволяет получить данные об авторе
        /// литературного источника.</summary>
        public abstract string Author { get; set; }
        /// <summary>
        /// Абстрактное свойство <c>Title</c> возвращает название литературного источника.
        /// </summary>
        public abstract string Title { get; set; }
        /// <summary>Конструктор поумолчанию для класса Source</summary>
        public Source() { }

        /// <summary>
        /// Абстрактный метод <c>GetPublicationInfo()</c> выводит информацию
        /// об источнике.
        /// </summary>
        public abstract void GetPublicationInfo();
    }

    /// <summary>
    /// Класс <c>Book</c>, производный от Source, содержит информацию о книжных изданиях.
    /// </summary>
    [Serializable]
    public class Book : Source
    {
        /// <summary>Конструктор поумолчанию для класса Book</summary>
        public Book() { }

        /// <summary>Конструктор класса Book</summary>
        /// <param name="title">string</param>
        /// <param name="author">string</param>
        /// <param name="publisher">string value</param>
        /// <param name="yearOfPubl">Int16 value</param>
        public Book(string title, string author, string publisher, short yearOfPubl)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            YearOfPubl = yearOfPubl;
            Trace.WriteLine("constructor was called;", this.GetType().Name);
        }

        /// <summary>
        /// Cвойство <c>Title</c> возвращает название книги.<see cref="Source.Title"/>
        /// </summary>
        public override string Title { get;  set; }

        /// <summary>Cвойство <c>Author</c> возвращает информацию об авторе книги.<see cref="Source.Author"/></summary>
        public override string Author { get;  set; }

        /// <summary>Cвойство <c>YearOfPubl</c> возвращает год издания книги</summary>
        public short YearOfPubl { get;  set; }

        /// <summary>Cвойство <c>Publisher</c> возвращает издателя книги</summary>
        public string Publisher { get;  set; }

        /// <summary>Метод <c>GetPublicationInfo()</c> выводит информацию о книге.</summary>
        public override void GetPublicationInfo()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Year of publication: " + YearOfPubl);
            Console.WriteLine("Publisher: " + Publisher);
            Trace.WriteLine("method GetPublicationInfo was called;", this.GetType().Name);
        }
    }
    /// <summary>
    /// Класс <c>Paper</c>, производный от Source, содержит информацию о журнальных статьях.
    /// </summary>
    [Serializable]
    public class Paper : Source
    {
        /// <summary>Конструктор поумолчанию для класса Paper</summary>
        public Paper() { }

        /// <summary>Конструктор класса <c>Paper</c></summary>
        /// <param name="title"> </param>
        /// <param name="author"> </param>
        /// <param name="magazine"> </param>
        /// <param name="magazineNo"> </param>
        /// <param name="yearOfPubl">Int16 value</param>
        public Paper(string title, string author, string magazine, byte magazineNo, short yearOfPubl)
        {
            Title = title;
            Author = author;
            Magazine = magazine;
            MagazineNo = magazineNo;
            YearOfPubl = yearOfPubl;
            Trace.WriteLine("constructor was called;", this.GetType().Name);
        }

        /// <summary>Cвойство <c>Title</c> возвращает название статьи.<see cref="Source.Title"/></summary>
        public override string Title { get;  set; }

        /// <summary>Cвойство <c>Author</c> возвращает информацию об авторе статьи.<see cref="Source.Author"/></summary>
        public override string Author { get;  set; }

        /// <summary>Cвойство <c>Magazine</c> возвращает название периодического издания, 
        /// в котором опубликована статья.</summary>
        public string Magazine { get;  set; }

        /// <summary>Cвойство <c>MagazineNo</c> возвращает номер периодического издания, 
        /// в котором опубликована статья.</summary>
        public byte MagazineNo { get;  set; }

        /// <summary>Cвойство <c>YearOfPubl</c> возвращает год публикации статьи.</summary>
        public short YearOfPubl { get;  set; }

        /// <summary>Метод <c>GetPublicationInfo()</c> выводит информацию о статье.</summary>
        public override void GetPublicationInfo()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Magazine: " + Magazine);
            Console.WriteLine("Magazine Number: " + MagazineNo);
            Console.WriteLine("Year of publication: " + YearOfPubl);
            Trace.WriteLine("method GetPublicationInfo was called;", this.GetType().Name);
        }
    }
    /// <summary>
    /// Класс <c>EResources</c>, производный от Source, содержит информацию об электронных ресурсах.
    /// </summary>
    [Serializable]
    public class EResources : Source
    {
        /// <summary>Конструктор поумолчанию для класса EResources</summary>
        public EResources() { }

        /// <summary>Конструктор класса <c>EResources</c></summary>
        /// <param name="title"> string</param>
        /// <param name="author"> </param>
        /// <param name="reference"> </param>
        /// <param name="annotation"> </param>
        public EResources(string title, string author, string reference, string annotation)
        {
            Title = title;
            Author = author;
            Reference = reference;
            Annotation = annotation;
            Trace.WriteLine("constructor was called;", this.GetType().Name);
        }

        /// <summary>Cвойство <c>Title</c> возвращает название электронной публикации.<see cref="Source.Title"/></summary>
        public override string Title { get;  set; }

        /// <summary>Cвойство <c>Author</c> возвращает информацию об авторе электронной публикации.<see cref="Source.Author"/></summary>
        public override string Author { get;  set; }

        /// <summary>Cвойство <c>Reference</c> возвращает ссылку на электронную публикацию.</summary>
        public string Reference { get;  set; }

        /// <summary>Cвойство <c>Annotation</c> возвращает описание электронной публикации</summary>
        public string Annotation { get;  set; }

        /// <summary>Метод <c>GetPublicationInfo()</c> выводит информацию об электронной публикации.</summary>
        public override void GetPublicationInfo()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Reference: " + Reference);
            Console.WriteLine("Annotation: " + Annotation);
            Trace.WriteLine("method GetPublicationInfo was called;", this.GetType().Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Трассировка
            Trace.Listeners.RemoveAt(0);
            DefaultTraceListener defaultListener;
            defaultListener = new DefaultTraceListener();
            Trace.Listeners.Add(defaultListener);
            //Сериализация
            XmlSerializer formatter = new XmlSerializer(typeof(Source[]),
                new Type[] { typeof(Book), typeof(Paper), typeof(EResources)});


            string strSearch;
            bool found = false;
            //каталог для хранения 
            Source[] catalog = null;
            string workDir = Environment.CurrentDirectory;
            string path = Directory.GetParent(workDir).Parent.Parent.FullName;
            Console.WriteLine(workDir);
            Console.ReadKey();

            defaultListener.LogFileName = path + "/Log.txt";

            StreamReader sIn = null;
            try
            {
                //var enc1252 = System.Text.CodePagesEncodingProvider.Instance.GetEncoding(1252);

                sIn = new StreamReader(path + "/Input.txt", Encoding.UTF8);
                int n = Int16.Parse(sIn.ReadLine());
                catalog = new Source[n];
                string srcType;
                string srcAuthor;
                string srcTitle;
                string srcPublishier;
                string srcYear;
                string srcRef;
                string srcAnn;
                string srcMagazine;
                string srcMagNo;
                int i = 0;
                while ((i < n) && (!sIn.EndOfStream))
                {

                    srcType = sIn.ReadLine();
                    if (srcType == "Book")
                    {
                        srcAuthor = sIn.ReadLine();
                        srcTitle = sIn.ReadLine();
                        srcPublishier = sIn.ReadLine();
                        srcYear = sIn.ReadLine();
                        catalog[i] = new Book(srcTitle, srcAuthor, srcPublishier, Int16.Parse(srcYear));
                        i++;
                    }

                    else if (srcType == "Paper")
                    {
                        srcAuthor = sIn.ReadLine();
                        srcTitle = sIn.ReadLine();
                        srcMagazine = sIn.ReadLine();
                        srcYear = sIn.ReadLine();
                        srcMagNo = sIn.ReadLine();
                        catalog[i] = new Paper(srcTitle, srcAuthor, srcMagazine, Byte.Parse(srcMagNo), Int16.Parse(srcYear));
                        i++;
                    }
                    else if (srcType == "EResources")
                    {
                        srcAuthor = sIn.ReadLine();
                        srcTitle = sIn.ReadLine();
                        srcRef = sIn.ReadLine();
                        srcAnn = sIn.ReadLine();
                        catalog[i] = new EResources(srcTitle, srcAuthor, srcRef, srcAnn);
                        i++;
                    }

                };

            }
            catch
            {
                Console.WriteLine("\nRead from file failed: \n" + path);
                if (!File.Exists(path))
                    Console.WriteLine("File does not exist");//throw new ArgumentNullException("File does not exist", e);
                                                             //else
                                                             //throw new ArgumentException("Some Read Exception", e);
            }
            finally
            {
                if (sIn != null) sIn.Close();

            }
            //Вывод каталога
            if (catalog != null)
            {
                Console.WriteLine("\nCatalog is ready");

                foreach (Source src in catalog)
                {
                    if (src != null)
                    {
                        src.GetPublicationInfo();
                        Console.WriteLine();
                    }
                }
            }
            //Сериализация
            using (FileStream fs = new FileStream(path+"/Сatalog.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, catalog);
            }
            //Поиск по каталогу
            while (!(Console.ReadKey(true).Key == ConsoleKey.Escape))
            {
                Console.WriteLine("Enter author name you want to search for");
                strSearch = Console.ReadLine().ToLower();
                if (!String.IsNullOrWhiteSpace(strSearch))
                {
                    foreach (Source src in catalog)
                    {
                        if (src.Author.ToLower().Contains(strSearch))
                        {
                            found = true;
                            src.GetPublicationInfo();
                        }
                    }
                    if (!found)
                        Console.WriteLine("\nAuthor not found");
                    Console.WriteLine("\nPress ESC to stop");
                    found = false;
                }
            }
            Console.ReadKey();
        }
    }
}
