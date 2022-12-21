using System.Configuration;
using System.Data;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.Generic;
using TP2.classes;

namespace TP2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static new App Current { get { return (App)Application.Current; } }

        public User? CurrentUser;
        public int CurrentUserId;

        public Dictionary<int, Car> Cars = new Dictionary<int, Car>()
        {
            { 1, new Car(){Id=1, Image="car1.jpg",Titre="",Description="",Fabricants="Honda",Price=1000,Marque="civic",Annee=2001,Odometre=350} },
            {2, new Car(){Id=2, Image="car2.jpg",Titre="",Description="", Price=6000   ,Fabricants=" Honda "  ,Marque="Accord  " ,Annee= 2014    ,Odometre =170} },
            {3, new Car(){Id=3, Image="car3.jpg",Titre="",Description="", Price=5000   ,Fabricants=" Toyota"  ,Marque="Camry   " ,Annee= 2015    ,Odometre =200} },
            {4, new Car(){Id=4, Image="car4.jpg",Titre="",Description="", Price=8000   ,Fabricants=" Nissan"  ,Marque="Leaf    " ,Annee= 2013    ,Odometre =210} },
            {5, new Car(){Id=5, Image="car5.jpg",Titre="",Description="", Price=10000  ,Fabricants=" Toyota"  ,Marque="Yaris   " ,Annee= 2021    ,Odometre =20} },
            {6, new Car(){Id=6, Image="car6.jpg",Titre="",Description="", Price=1000  ,Fabricants="  Honda"  ,Marque=" Civic  " ,Annee=  2001   ,Odometre = 350} },
            {7, new Car(){Id=7, Image="car7.jpg",Titre="",Description="", Price=6000  ,Fabricants="  Honda"  ,Marque=" Civic  " ,Annee=  2011   ,Odometre = 140} },
            {8, new Car(){Id=8, Image="car8.jpg",Titre="",Description="", Price=20000  ,Fabricants=" Toyota"  ,Marque="Camry   " ,Annee= 2021    ,Odometre =10} },
            {9, new Car(){Id=9, Image="car9.jpg",Titre="",Description="", Price=7000   ,Fabricants=" Nissan"  ,Marque="Infiniti" ,Annee= 2015,    Odometre =150} },
            {10, new Car(){Id=10, Image="car10.jpg",Titre="",Description="", Price=9000   ,Fabricants=" Nissan"  ,Marque="Infiniti" ,Annee=2016,    Odometre = 170} },
            {11, new Car(){Id=11, Image="car11.jpg",Titre="",Description="", Price=12000  ,Fabricants=" Honda "  ,Marque="Accord  " ,Annee= 2018    ,Odometre =90} },
            {12, new Car(){Id=12, Image="car12.jpg",Titre="",Description="", Price=5000   ,Fabricants=" Toyota"  ,Marque="Yaris   " ,Annee= 2013    ,Odometre =210} },
            {13, new Car(){Id=13, Image="car13.jpg",Titre="",Description="", Price=2000   ,Fabricants=" Nissan"  ,Marque="Altima  " ,Annee= 2003    ,Odometre =320 } }

        };

        public Dictionary<int, User> Users = new Dictionary<int, User>()
        {
            {1, new User(){FirstName="Tom",LastName="Richards", MailAddress="TomRichards@gmail.com",Password="trichards",ProfilePicture="user1.jpg",FriendsIds= new List<int>(){ 2,3,4 } } },
            {2, new User(){FirstName="Elliot",LastName="Hart", MailAddress="ElliotHart@gmail.com",Password="ehart",ProfilePicture="user2.jpg",FriendsIds= new List<int>(){ 1,3 } } },
            {3, new User(){FirstName="Rachel",LastName="Chapman", MailAddress="RachelChapman@gmail.com",Password="rchapman",ProfilePicture="user3.jpg",FriendsIds= new List<int>(){ 1,2,4 }} },
            {4, new User(){FirstName="Myriam",LastName="Leblanc", MailAddress="MyriamLeblanc@gmail.com",Password="mleblanc",ProfilePicture="user4.jpg",FriendsIds= new List<int>(){ 3 }} },
            {5, new User(){FirstName="Paul",LastName="Burnham", MailAddress="PaulBurnham@gmail.com",Password="pburnham",ProfilePicture="user5.jpg",FriendsIds= new List<int>(){  }} },
        };

        public Dictionary<int, Post> Posts = new Dictionary<int, Post>()
        {
            {1,new Post(){ UserId=1, Title="Nice snack with a book",Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras id consectetur quam. Nam rutrum non dui et feugiat. Morbi a mattis leo. Phasellus efficitur nulla dignissim ipsum commodo, in maximus leo dignissim. Donec venenatis posuere justo quis pulvinar. Etiam eu neque nibh. Vivamus egestas sollicitudin dictum. Nunc tempus orci vel enim facilisis, sit amet rhoncus mi bibendum. Donec vel venenatis orci. Fusce ultricies libero id nulla dignissim, non molestie nunc placerat. Vestibulum hendrerit mi aliquet ante feugiat, a semper augue volutpat. Aenean leo est, sagittis non enim quis, aliquam vestibulum odio. Sed et suscipit orci.",Image="Post1.jpg",Date="2021-11-20 07:00",Visibility="Public",Like=new List<int>(),Love=new List<int>(),Sad=new List<int>(),Angry=new List<int>(),Comments=new List<Comment>()} },
            {2,new Post(){ UserId=2, Title="Relaxing night at the beach",Description="Aenean vehicula ligula id nisl dapibus auctor. Aliquam ornare, libero eu pulvinar aliquam, sem lorem fermentum nisl, sed convallis lacus sem ut nulla. Suspendisse potenti. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer at rutrum dui. Ut at dolor leo. Maecenas id fringilla diam. Curabitur aliquet efficitur diam sed iaculis. Sed vulputate faucibus facilisis. Quisque tincidunt libero sit amet est dignissim, vitae egestas dui rutrum. Etiam non nisi quis elit consequat pretium non quis ante. Phasellus nec leo est. Vestibulum porttitor ac mauris sit amet tincidunt.",Image="Post2.jpg",Date="2021-11-21 10:30",Visibility="Public",Like=new List<int>() { 1 },Love=new List<int>(),Sad=new List<int>(),Angry=new List<int>(),Comments=new List<Comment>()} },
            {3,new Post(){ UserId=3, Title="Trekking in the woods",Description="Fusce tincidunt lorem mauris, id cursus nunc bibendum quis. Etiam sed malesuada arcu, ut tempus ligula. Ut quis erat non augue molestie scelerisque vel eu lectus. Sed et sapien blandit, iaculis tortor id, cursus nisl. Quisque facilisis congue iaculis. Ut bibendum, orci in posuere efficitur, augue diam posuere massa, quis ultrices augue nibh non est. Donec orci est, egestas a eros non, rutrum luctus neque. Nulla finibus erat in dictum laoreet. Nulla nec enim vitae nisl pulvinar maximus.",Image="Post3.jpg",Date="2021-11-22 16:30",Visibility="Public",Like=new List<int>(),Love=new List<int>() {1 },Sad=new List<int>(),Angry=new List<int>(),Comments=new List<Comment>()} },
            {4,new Post(){ UserId=4, Title="King of the world!",Description="Phasellus viverra sed ante et egestas. Ut rhoncus ac enim id iaculis. Pellentesque elementum elit orci, nec molestie tellus ornare et. Nam pulvinar laoreet lobortis. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Integer gravida odio id tortor posuere laoreet. Cras mattis tortor vitae orci semper porttitor. Proin luctus purus ut quam rhoncus volutpat. Proin ac suscipit velit. Cras quis erat varius, lacinia ligula ac, tristique dui.",Image="Post4.jpg",Date="2021-11-23 21:00",Visibility="Public",Like=new List<int>(),Love=new List<int>(),Sad=new List<int>() { 1 },Angry=new List<int>() { 2 },Comments=new List<Comment>()} },
            {5,new Post(){ UserId=5, Title="After work",Description="Nulla tincidunt eros eros, eget pulvinar massa suscipit eu. In eu leo enim. Aliquam sed feugiat magna. Nunc aliquet mauris dapibus, eleifend sapien quis, lobortis lectus. In hac habitasse platea dictumst. Mauris nec fermentum mauris. Maecenas eleifend tincidunt tortor ut mattis. Nulla feugiat sollicitudin quam in sagittis. Quisque in nisi eu purus fringilla pretium sit amet eget turpis. Vivamus sagittis elit non erat pulvinar tristique. Vivamus hendrerit porta purus id convallis. Praesent efficitur lectus lacus, eu pulvinar velit scelerisque sit amet. Duis vestibulum mattis leo, non viverra arcu mollis ac. Morbi a auctor quam.",Image="Post5.jpg",Date="2021-11-24 12:00",Visibility="Public",Like=new List<int>(),Love=new List<int>(),Sad=new List<int>(),Angry=new List<int>(),Comments=new List<Comment>()} },
            {6,new Post(){ UserId=1, Title="New Zealand 2017",Description="Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Quisque varius malesuada tellus ut tincidunt. Sed porta suscipit tortor. Ut faucibus felis eu aliquet scelerisque. Nunc ut diam ornare, auctor felis pharetra, placerat lectus. Nunc mi ligula, sodales vitae augue a, volutpat vulputate mi. Proin ultricies sit amet lacus ac tempor. Morbi dapibus elit in magna sodales, sed condimentum libero scelerisque. Donec sit amet sapien pharetra, aliquam augue ac, feugiat ex. Donec sed erat sem. Curabitur consequat finibus vestibulum. Duis vel feugiat nisi. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Fusce sit amet aliquet nisl, ac iaculis ex. Nullam elementum quis elit et eleifend. Fusce in maximus neque.",Image="Post6.jpg",Date="2021-11-25 01:00",Visibility="FriendsOnly",Like=new List<int>(),Love=new List<int>() { 2 },Sad=new List<int>(),Angry=new List<int>(),Comments=new List<Comment>()} },
            {7,new Post(){ UserId=1, Title="Sweden 2018",Description="Donec venenatis aliquet lectus, a tempor ex convallis vel. Mauris eros eros, iaculis non volutpat id, pulvinar ac sapien. In auctor, orci blandit accumsan tristique, quam ipsum tempor ante, sed condimentum nunc lectus non massa. Nunc fermentum nunc ipsum, nec lacinia dolor rhoncus id. Maecenas faucibus nisi nec massa vulputate ornare. Nulla ac sem vel augue accumsan placerat quis vitae ante. Morbi ornare justo mollis libero laoreet, in efficitur orci tristique. Proin nec consequat sem, in maximus augue. Proin vitae nunc eu felis cursus interdum.",Image="Post7.jpg",Date="2021-11-26 09:00",Visibility="FriendsExcept Rachel",Like=new List<int>(),Love=new List<int>(),Sad=new List<int>() { 3 },Angry=new List<int>(),Comments=new List<Comment>()} },
            {8,new Post(){ UserId=1, Title="Internet cafe Sundays",Description="In ullamcorper pulvinar ex eget fringilla. Ut luctus sed ante vitae posuere. Quisque quis tortor pharetra, tincidunt risus nec, tincidunt dui. Phasellus sagittis sollicitudin tellus. Morbi volutpat tristique dapibus. Ut ut felis facilisis, scelerisque sem sit amet, ultrices felis. Cras rhoncus diam ac leo mattis tristique. Sed vel vestibulum eros. Fusce at iaculis arcu, et porttitor eros.",Image="Post8.jpg",Date="2021-11-27 11:30",Visibility="FriendsSpecific Rachel",Like=new List<int>(),Love=new List<int>(),Sad=new List<int>(),Angry=new List<int>(),Comments=new List<Comment>()} },
            {9,new Post(){ UserId=2, Title="Surprise!",Description="Duis quis sapien ex. Nam in est eget nisi ultricies scelerisque nec vitae metus. Aenean pulvinar ut dui et rhoncus. Nam dolor ipsum, vulputate in sapien nec, pellentesque feugiat nulla. Proin aliquet tempus tincidunt. Phasellus id faucibus velit. Nullam non nisi lectus. Praesent in arcu eget urna aliquet egestas eu eget nibh. Sed bibendum eget magna id pretium.",Image="Post9.jpg",Date="2021-11-28 14:30",Visibility="FriendsOnly",Like=new List<int>(),Love=new List<int>() { 1,3 },Sad=new List<int>(),Angry=new List<int>(),Comments=new List<Comment>()} },
            {10,new Post(){ UserId=2, Title="Secret painting",Description="Cras sit amet dictum arcu, sit amet tempus ante. Aliquam nisi augue, pharetra nec erat vitae, aliquam fermentum arcu. Duis viverra arcu ac magna cursus bibendum. Etiam laoreet semper felis, tincidunt tristique lorem placerat vel. Nam leo nisl, tempor ut facilisis fermentum, maximus at odio. Donec et laoreet sem, non mattis sem. Sed accumsan at sem non egestas. Donec ultricies libero ultricies tellus euismod, eu sollicitudin nisl dictum. Quisque non consequat purus, sit amet dignissim justo. Ut placerat dolor vel tellus viverra, malesuada tempus ante sodales. Nullam dignissim at nulla vel volutpat. Phasellus egestas ultrices scelerisque. Integer tellus enim, convallis ut elit vel, pretium facilisis orci. Mauris fringilla velit metus, sed gravida elit blandit at.",Image="Post10.jpg",Date="2021-11-29 17:30",Visibility="OnlyMe",Like=new List<int>(),Love=new List<int>(),Sad=new List<int>() { 2 } ,Angry=new List<int>(),Comments=new List<Comment>()} }
        };


        // ==============================================================================
        // Mockup Olivier

        //https://startupheretoronto.com/wp-content/uploads/2019/03/default-user-image-2.png






        // ==============================================================================
        // Mockup Vincent



    }
}
