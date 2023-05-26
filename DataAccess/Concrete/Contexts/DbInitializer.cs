using Entities.Concrete;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.Contexts
{
    public static class DbInitializer
    {
        public static void Initilize(YoklamaContext context)
        {
            context.Database.EnsureCreated();
            if (context.Persons.Any())
            {
                return;
            }

            var persons = new Person[] {
                new Person() {STATUS=1,MERNISNO=99999999999,GENDER=Gender.Unknown,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Sistem",SURNAME="Yönetimi" },
                new Person() {STATUS=1,MERNISNO=10000010001,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Nebahat",SURNAME="Akkiraz" },
                new Person() {STATUS=1,MERNISNO=10000010002,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Elif",SURNAME="Şahin" },
                new Person() {STATUS=1,MERNISNO=10000010003,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Ahmet",SURNAME="Yılmaz" },
                new Person() {STATUS=1,MERNISNO=10000010004,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Ayşe",SURNAME="Demir" },
                new Person() {STATUS=1,MERNISNO=10000010005,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Mehmet",SURNAME="Kaya" },
                new Person() {STATUS=1,MERNISNO=10000010006,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Zeynep",SURNAME="Arslan" },
                new Person() {STATUS=1,MERNISNO=10000010007,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Selen",SURNAME="Aydın" },
                new Person() {STATUS=1,MERNISNO=10000010008,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Berkay",SURNAME="Kara" },
                new Person() {STATUS=1,MERNISNO=10000010009,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Ceren",SURNAME="Öztürk" },
                new Person() {STATUS=1,MERNISNO=10000010010,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Emir",SURNAME="Can" },
                new Person() {STATUS=1,MERNISNO=10000010011,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Elif",SURNAME="Demir" },
                new Person() {STATUS=1,MERNISNO=10000010012,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Ahmet",SURNAME="Kaya" },
                new Person() {STATUS=1,MERNISNO=10000010013,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Zeynep",SURNAME="Arslan" },
                new Person() {STATUS=1,MERNISNO=10000010014,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Mehmet",SURNAME="Yılmaz" },
                new Person() {STATUS=1,MERNISNO=10000010015,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Ayşe",SURNAME="Şahin" },
                new Person() {STATUS=1,MERNISNO=10000010016,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Ceren",SURNAME="Öztürk" },
                new Person() {STATUS=1,MERNISNO=10000010017,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Ali",SURNAME="Aydın" },
                new Person() {STATUS=1,MERNISNO=10000010018,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Selen",SURNAME="Çelik" },
                new Person() {STATUS=1,MERNISNO=10000010019,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Berkay",SURNAME="Kara" },
                new Person() {STATUS=1,MERNISNO=10000010020,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Deniz",SURNAME="Özdemir" },
                new Person() {STATUS=1,MERNISNO=10000010021,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Ece",SURNAME="Koç" },
                new Person() {STATUS=1,MERNISNO=10000010022,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Murat",SURNAME="Aksoy" },
                new Person() {STATUS=1,MERNISNO=10000010023,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Seda",SURNAME="Kurt" },
                new Person() {STATUS=1,MERNISNO=10000010024,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Emre",SURNAME="Güneş" },
                new Person() {STATUS=1,MERNISNO=10000010025,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Sevgi",SURNAME="Ateş" },
                new Person() {STATUS=1,MERNISNO=10000010026,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Yasin",SURNAME="Cengiz" },
                new Person() {STATUS=1,MERNISNO=10000010027,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Cansu",SURNAME="Eren" },
                new Person() {STATUS=1,MERNISNO=10000010028,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Furkan",SURNAME="Türk" },
                new Person() {STATUS=1,MERNISNO=10000010029,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Elif",SURNAME="Öztürk" },
                new Person() {STATUS=1,MERNISNO=10000010030,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Melis",SURNAME="Güler" },
                new Person() {STATUS=1,MERNISNO=10000010031,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Can",SURNAME="Karaca" },
                new Person() {STATUS=1,MERNISNO=10000010032,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Esra",SURNAME="Şimşek" },
                new Person() {STATUS=1,MERNISNO=10000010033,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Mustafa",SURNAME="Toprak" },
                new Person() {STATUS=1,MERNISNO=10000010034,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Selin",SURNAME="Akgül" },
                new Person() {STATUS=1,MERNISNO=10000010035,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Emir",SURNAME="Gündüz" },
                new Person() {STATUS=1,MERNISNO=10000010036,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Büşra",SURNAME="Demirci" },
                new Person() {STATUS=1,MERNISNO=10000010037,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Serkan",SURNAME="Yavuz" },
                new Person() {STATUS=1,MERNISNO=10000010038,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="İrem",SURNAME="Aydın" },
                new Person() {STATUS=1,MERNISNO=10000010039,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Gökhan",SURNAME="Kılıç" },
                new Person() {STATUS=1,MERNISNO=10000010040,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Merve",SURNAME="Özkan" },
                new Person() {STATUS=1,MERNISNO=10000010041,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Hakan",SURNAME="Güzel" },
                new Person() {STATUS=1,MERNISNO=10000010042,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Gamze",SURNAME="Alkan" },
                new Person() {STATUS=1,MERNISNO=10000010043,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Emre",SURNAME="Kara" },
                new Person() {STATUS=1,MERNISNO=10000010044,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Beyza",SURNAME="Şahin" },
                new Person() {STATUS=1,MERNISNO=10000010045,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Okan",SURNAME="Yıldırım" },
                new Person() {STATUS=1,MERNISNO=10000010046,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Duygu",SURNAME="Keskin" },
                new Person() {STATUS=1,MERNISNO=10000010047,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Cihan",SURNAME="Erdem" },
                new Person() {STATUS=1,MERNISNO=10000010048,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Şeyma",SURNAME="Bulut" },
                new Person() {STATUS=1,MERNISNO=10000010049,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Yusuf",SURNAME="Akbulut" },
                new Person() {STATUS=1,MERNISNO=10000010050,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Deniz",SURNAME="Kurtuluş" },
                new Person() {STATUS=1,MERNISNO=10000010051,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="İpek",SURNAME="Karakuş" },
                new Person() {STATUS=1,MERNISNO=10000010052,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Fatih",SURNAME="Güneş" },
                new Person() {STATUS=1,MERNISNO=10000010053,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Gizem",SURNAME="Ateş" },
                new Person() {STATUS=1,MERNISNO=10000010054,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Ferhat",SURNAME="Kılıç" },
                new Person() {STATUS=1,MERNISNO=10000010055,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Yasemin",SURNAME="Türk" },
                new Person() {STATUS=1,MERNISNO=10000010056,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Onur",SURNAME="Güler" },
                new Person() {STATUS=1,MERNISNO=10000010057,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Gizem",SURNAME="Karaca" },
                new Person() {STATUS=1,MERNISNO=10000010058,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Kerem",SURNAME="Şimşek" },
                new Person() {STATUS=1,MERNISNO=10000010059,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Ayşe",SURNAME="Toprak" },
                new Person() {STATUS=1,MERNISNO=10000010060,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Ahmet",SURNAME="Akgül" },
                new Person() {STATUS=1,MERNISNO=10000010061,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Zeynep",SURNAME="Gündüz" },
                new Person() {STATUS=1,MERNISNO=10000010062,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Mehmet",SURNAME="Demirci" },
                new Person() {STATUS=1,MERNISNO=10000010063,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Aylin",SURNAME="Yavuz" },
                new Person() {STATUS=1,MERNISNO=10000010064,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Ali",SURNAME="Aydın" },
                new Person() {STATUS=1,MERNISNO=10000010065,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Selin",SURNAME="Kılıç" },
                new Person() {STATUS=1,MERNISNO=10000010066,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Emre",SURNAME="Özkan" },
                new Person() {STATUS=1,MERNISNO=10000010067,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Büşra",SURNAME="Güzel" },
                new Person() {STATUS=1,MERNISNO=10000010068,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Serkan",SURNAME="Alkan" },
                new Person() {STATUS=1,MERNISNO=10000010079,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="İrem",SURNAME="Kara" },
                new Person() {STATUS=1,MERNISNO=10000010070,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Gökhan",SURNAME="Şahin" },
                new Person() {STATUS=1,MERNISNO=10000010071,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Merve",SURNAME="Yıldırım" },
                new Person() {STATUS=1,MERNISNO=10000010072,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Hakan",SURNAME="Keskin" },
                new Person() {STATUS=1,MERNISNO=10000010073,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Gamze",SURNAME="Erdem" },
                new Person() {STATUS=1,MERNISNO=10000010074,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Emre",SURNAME="Bulut" },
                new Person() {STATUS=1,MERNISNO=10000010075,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Beyza",SURNAME="Akbulut" },
                new Person() {STATUS=1,MERNISNO=10000010076,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Okan",SURNAME="Kurtuluş" },
                new Person() {STATUS=1,MERNISNO=10000010077,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Duygu",SURNAME="Karakuş" },
                new Person() {STATUS=1,MERNISNO=10000010078,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Cihan",SURNAME="Güneş" },
                new Person() {STATUS=1,MERNISNO=10000010079,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Şeyma",SURNAME="Ateş" },
                new Person() {STATUS=1,MERNISNO=10000010080,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Yusuf",SURNAME="Kılıç" },
                new Person() {STATUS=1,MERNISNO=10000010081,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Deniz",SURNAME="Türk" },
                new Person() {STATUS=1,MERNISNO=10000010082,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="İpek",SURNAME="Güler" },
                new Person() {STATUS=1,MERNISNO=10000010083,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Fatih",SURNAME="Karaca" },
                new Person() {STATUS=1,MERNISNO=10000010084,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Gizem",SURNAME="Şimşek" },
                new Person() {STATUS=1,MERNISNO=10000010085,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Ferhat",SURNAME="Toprak" },
                new Person() {STATUS=1,MERNISNO=10000010086,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Yasemin",SURNAME="Akgül" },
                new Person() {STATUS=1,MERNISNO=10000010087,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Onur",SURNAME="Gündüz" },
                new Person() {STATUS=1,MERNISNO=10000010088,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Gizem",SURNAME="Demirci" },
                new Person() {STATUS=1,MERNISNO=10000010089,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Kerem",SURNAME="Yavuz" },
                new Person() {STATUS=1,MERNISNO=10000010090,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Ayşe",SURNAME="Aydın" },
                new Person() {STATUS=1,MERNISNO=10000010091,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Ahmet",SURNAME="Kılıç" },
                new Person() {STATUS=1,MERNISNO=10000010092,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Zeynep",SURNAME="Özkan" },
                new Person() {STATUS=1,MERNISNO=10000010093,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Mehmet",SURNAME="Güzel" },
                new Person() {STATUS=1,MERNISNO=10000010094,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Aylin",SURNAME="Alkan" },
                new Person() {STATUS=1,MERNISNO=10000010095,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Ali",SURNAME="Kara" },
                new Person() {STATUS=1,MERNISNO=10000010096,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Selin",SURNAME="Şahin" },
                new Person() {STATUS=1,MERNISNO=10000010097,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Emre",SURNAME="Yıldırım" },
                new Person() {STATUS=1,MERNISNO=10000010098,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Büşra",SURNAME="Keskin" },
                new Person() {STATUS=1,MERNISNO=10000010099,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Serkan",SURNAME="Erdem" },
                new Person() {STATUS=1,MERNISNO=10000010100,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="İrem",SURNAME="Bulut" },
                new Person() {STATUS=1,MERNISNO=10000010101,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Gökhan",SURNAME="Akbulut" },
                new Person() {STATUS=1,MERNISNO=10000010102,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Merve",SURNAME="Kurtuluş" },
                new Person() {STATUS=1,MERNISNO=10000010103,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Hakan",SURNAME="Karakuş" },
                new Person() {STATUS=1,MERNISNO=10000010104,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Gamze",SURNAME="Güneş" },
                new Person() {STATUS=1,MERNISNO=10000010105,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Emre",SURNAME="Ateş" },
                new Person() {STATUS=1,MERNISNO=10000010106,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Beyza",SURNAME="Kılıç" },
                new Person() {STATUS=1,MERNISNO=10000010107,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Okan",SURNAME="Türk" },
                new Person() {STATUS=1,MERNISNO=10000010108,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Duygu",SURNAME="Güler" },
                new Person() {STATUS=1,MERNISNO=10000010109,GENDER=Gender.Male,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Cihan",SURNAME="Karaca" },
                new Person() {STATUS=1,MERNISNO=10000010110,GENDER=Gender.Female,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,NAME="Şeyma",SURNAME="Şimşek" }
            };
            context.Persons.AddRange(persons);

            var users = new User[] {
                new User() {STATUS=1,Person=persons[0],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,USERNAME="99999999999",PASSWORD="99999",UserType=UserType.Admin },
                new User() {STATUS=1,Person=persons[1],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,USERNAME="10000010001",PASSWORD="10001",UserType=UserType.Teacher },
                new User() {STATUS=1,Person=persons[2],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,USERNAME="10000010002",PASSWORD="10002",UserType=UserType.Teacher },
                new User() {STATUS=1,Person=persons[3],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,USERNAME="10000010003",PASSWORD="10003",UserType=UserType.Teacher },
                new User() {STATUS=1,Person=persons[4],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,USERNAME="10000010004",PASSWORD="10004",UserType=UserType.Teacher },
                new User() {STATUS=1,Person=persons[5],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,USERNAME="10000010005",PASSWORD="10005",UserType=UserType.Teacher },
                new User() {STATUS=1,Person=persons[6],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,USERNAME="10000010006",PASSWORD="10006",UserType=UserType.Teacher },
                new User() {STATUS=1,Person=persons[7],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,USERNAME="10000010007",PASSWORD="10007",UserType=UserType.Teacher },
                new User() {STATUS=1,Person=persons[8],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,USERNAME="10000010008",PASSWORD="10008",UserType=UserType.Teacher },
                new User() {STATUS=1,Person=persons[9],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,USERNAME="10000010009",PASSWORD="10009",UserType=UserType.Teacher },
                new User() {STATUS=1,Person=persons[10],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,USERNAME="10000010010",PASSWORD="10010",UserType=UserType.Teacher }
            };
            context.Users.AddRange(users);

            var brancs = new Branch[] {
                new Branch() {STATUS=1,NAME="Matematik",CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Branch() {STATUS=1,NAME="Fizik",CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Branch() {STATUS=1,NAME="Kimya",CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Branch() {STATUS=1,NAME="Biyoloji",CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Branch() {STATUS=1,NAME="Türkçe",CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Branch() {STATUS=1,NAME="Tarih",CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Branch() {STATUS=1,NAME="Coğrafya",CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Branch() {STATUS=1,NAME="Resim",CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Branch() {STATUS=1,NAME="Müzik",CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Branch() {STATUS=1,NAME="Beden Eğitimi",CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Branch() {STATUS=1,NAME="Din Kültürü Ve Ahlak Bilgisi",CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Branch() {STATUS=1,NAME="İngilizce",CREATEDBY=99999999999,CREATIONDATE=DateTime.Now }
            };
            context.Branchs.AddRange(brancs);

            var schools = new School[] {
                new School() {STATUS=1,NAME="Adana Abdülkadir Paksoy Kız Lisesi",ACTIVE=true,CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new School() {STATUS=1,NAME="Ceyhan Lisesi",CREATEDBY=99999999999,CREATIONDATE=DateTime.Now }
            };
            context.Schools.AddRange(schools);


            var classrooms = new Classroom[] {
                new Classroom() {STATUS=1,NAME="9-A",School=schools[0],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Classroom() {STATUS=1,NAME="9-B",School=schools[0],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Classroom() {STATUS=1,NAME="9-C",School=schools[0],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Classroom() {STATUS=1,NAME="10-A",School=schools[0],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Classroom() {STATUS=1,NAME="10-B",School=schools[0],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Classroom() {STATUS=1,NAME="11-A",School=schools[0],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Classroom() {STATUS=1,NAME="11-B",School=schools[0],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Classroom() {STATUS=1,NAME="12-A",School=schools[0],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Classroom() {STATUS=1,NAME="12-B",School=schools[0],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Classroom() {STATUS=1,NAME="12-C",School=schools[0],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Classroom() {STATUS=1,NAME="9-A",School=schools[1],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Classroom() {STATUS=1,NAME="9-B",School=schools[1],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Classroom() {STATUS=1,NAME="9-C",School=schools[1],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Classroom() {STATUS=1,NAME="9-D",School=schools[1],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Classroom() {STATUS=1,NAME="9-E",School=schools[1],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Classroom() {STATUS=1,NAME="9-F",School=schools[1],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Classroom() {STATUS=1,NAME="10-A",School=schools[1],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Classroom() {STATUS=1,NAME="10-B",School=schools[1],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Classroom() {STATUS=1,NAME="10-C",School=schools[1],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Classroom() {STATUS=1,NAME="10-D",School=schools[1],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Classroom() {STATUS=1,NAME="10-E",School=schools[1],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Classroom() {STATUS=1,NAME="11-A",School=schools[1],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Classroom() {STATUS=1,NAME="11-B",School=schools[1],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Classroom() {STATUS=1,NAME="11-C",School=schools[1],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Classroom() {STATUS=1,NAME="11-D",School=schools[1],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Classroom() {STATUS=1,NAME="12-A",School=schools[1],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Classroom() {STATUS=1,NAME="12-B",School=schools[1],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Classroom() {STATUS=1,NAME="12-C",School=schools[1],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Classroom() {STATUS=1,NAME="12-D",School=schools[1],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Classroom() {STATUS=1,NAME="12-E",School=schools[1],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now }
            };
            context.Classrooms.AddRange(classrooms);

            var teachers = new Teacher[] {
                new Teacher() {STATUS=1,Person=persons[1],Branch=brancs[0],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,ACCESSCODE=10001 },
                new Teacher() {STATUS=1,Person=persons[2],Branch=brancs[1],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,ACCESSCODE=10002 },
                new Teacher() {STATUS=1,Person=persons[3],Branch=brancs[2],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,ACCESSCODE=10003 },
                new Teacher() {STATUS=1,Person=persons[4],Branch=brancs[3],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,ACCESSCODE=10004 },
                new Teacher() {STATUS=1,Person=persons[5],Branch=brancs[4],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,ACCESSCODE=10005 },
                new Teacher() {STATUS=1,Person=persons[6],Branch=brancs[5],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,ACCESSCODE=10006 },
                new Teacher() {STATUS=1,Person=persons[7],Branch=brancs[2],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,ACCESSCODE=10007 },
                new Teacher() {STATUS=1,Person=persons[8],Branch=brancs[3],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,ACCESSCODE=10008 },
                new Teacher() {STATUS=1,Person=persons[9],Branch=brancs[4],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,ACCESSCODE=10009 },
                new Teacher() {STATUS=1,Person=persons[10],Branch=brancs[5],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now,ACCESSCODE=10010 }
            };
            context.Teachers.AddRange(teachers);

            var schoolTeacher = new SchoolTeacher[] {
                new SchoolTeacher(){ School=schools[0],Teacher=teachers[0],ISDEFAULT=true},
                new SchoolTeacher(){ School=schools[1],Teacher=teachers[0],ISDEFAULT=false},
                new SchoolTeacher(){ School=schools[1],Teacher=teachers[1],ISDEFAULT=true},
                new SchoolTeacher(){ School=schools[0],Teacher=teachers[1],ISDEFAULT=false},
                new SchoolTeacher(){ School=schools[0],Teacher=teachers[2],ISDEFAULT=true},
                new SchoolTeacher(){ School=schools[0],Teacher=teachers[3],ISDEFAULT=true},
                new SchoolTeacher(){ School=schools[0],Teacher=teachers[4],ISDEFAULT=true},
                new SchoolTeacher(){ School=schools[0],Teacher=teachers[5],ISDEFAULT=true},
                new SchoolTeacher(){ School=schools[1],Teacher=teachers[6],ISDEFAULT=true},
                new SchoolTeacher(){ School=schools[1],Teacher=teachers[7],ISDEFAULT=true},
                new SchoolTeacher(){ School=schools[1],Teacher=teachers[8],ISDEFAULT=true},
                new SchoolTeacher(){ School=schools[1],Teacher=teachers[9],ISDEFAULT=true}
            };

            context.SchoolTeachers.AddRange(schoolTeacher);

            var students = new Student[] {
                new Student() {STATUS=1,SCHOOLNUMBER="11",School=schools[0],Person=persons[11],Classroom=classrooms[0],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="12",School=schools[0],Person=persons[12],Classroom=classrooms[0],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="13",School=schools[0],Person=persons[13],Classroom=classrooms[0],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="14",School=schools[0],Person=persons[14],Classroom=classrooms[0],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="15",School=schools[0],Person=persons[15],Classroom=classrooms[0],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="16",School=schools[0],Person=persons[16],Classroom=classrooms[0],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="17",School=schools[0],Person=persons[17],Classroom=classrooms[1],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="18",School=schools[0],Person=persons[18],Classroom=classrooms[1],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="19",School=schools[0],Person=persons[19],Classroom=classrooms[1],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="20",School=schools[0],Person=persons[20],Classroom=classrooms[1],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="21",School=schools[0],Person=persons[21],Classroom=classrooms[1],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="22",School=schools[0],Person=persons[22],Classroom=classrooms[1],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="23",School=schools[0],Person=persons[23],Classroom=classrooms[2],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="24",School=schools[0],Person=persons[24],Classroom=classrooms[2],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="25",School=schools[0],Person=persons[25],Classroom=classrooms[2],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="26",School=schools[0],Person=persons[26],Classroom=classrooms[2],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="27",School=schools[0],Person=persons[27],Classroom=classrooms[3],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="28",School=schools[0],Person=persons[28],Classroom=classrooms[3],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="29",School=schools[0],Person=persons[29],Classroom=classrooms[3],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="30",School=schools[0],Person=persons[30],Classroom=classrooms[3],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="31",School=schools[0],Person=persons[31],Classroom=classrooms[3],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="32",School=schools[0],Person=persons[32],Classroom=classrooms[4],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="33",School=schools[0],Person=persons[33],Classroom=classrooms[4],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="34",School=schools[0],Person=persons[34],Classroom=classrooms[4],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="35",School=schools[0],Person=persons[35],Classroom=classrooms[5],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="36",School=schools[0],Person=persons[36],Classroom=classrooms[5],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="37",School=schools[0],Person=persons[37],Classroom=classrooms[5],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="38",School=schools[0],Person=persons[38],Classroom=classrooms[6],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="39",School=schools[0],Person=persons[39],Classroom=classrooms[6],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="40",School=schools[0],Person=persons[40],Classroom=classrooms[6],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="41",School=schools[0],Person=persons[41],Classroom=classrooms[7],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="42",School=schools[0],Person=persons[42],Classroom=classrooms[7],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="43",School=schools[0],Person=persons[43],Classroom=classrooms[8],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="44",School=schools[0],Person=persons[44],Classroom=classrooms[8],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="45",School=schools[0],Person=persons[45],Classroom=classrooms[8],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="46",School=schools[0],Person=persons[46],Classroom=classrooms[9],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="47",School=schools[0],Person=persons[47],Classroom=classrooms[9],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="48",School=schools[0],Person=persons[48],Classroom=classrooms[9],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="49",School=schools[0],Person=persons[49],Classroom=classrooms[9],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="50",School=schools[0],Person=persons[50],Classroom=classrooms[9],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="51",School=schools[1],Person=persons[51],Classroom=classrooms[10],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="52",School=schools[1],Person=persons[52],Classroom=classrooms[10],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="53",School=schools[1],Person=persons[53],Classroom=classrooms[10],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="54",School=schools[1],Person=persons[54],Classroom=classrooms[10],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="55",School=schools[1],Person=persons[55],Classroom=classrooms[11],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="56",School=schools[1],Person=persons[56],Classroom=classrooms[11],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="57",School=schools[1],Person=persons[57],Classroom=classrooms[11],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="58",School=schools[1],Person=persons[58],Classroom=classrooms[11],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="59",School=schools[1],Person=persons[59],Classroom=classrooms[11],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="60",School=schools[1],Person=persons[60],Classroom=classrooms[11],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="61",School=schools[1],Person=persons[61],Classroom=classrooms[12],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="62",School=schools[1],Person=persons[62],Classroom=classrooms[12],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="63",School=schools[1],Person=persons[63],Classroom=classrooms[12],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="64",School=schools[1],Person=persons[64],Classroom=classrooms[12],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="65",School=schools[1],Person=persons[65],Classroom=classrooms[13],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="66",School=schools[1],Person=persons[66],Classroom=classrooms[13],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="67",School=schools[1],Person=persons[67],Classroom=classrooms[14],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="68",School=schools[1],Person=persons[68],Classroom=classrooms[14],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="69",School=schools[1],Person=persons[69],Classroom=classrooms[14],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="70",School=schools[1],Person=persons[70],Classroom=classrooms[15],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="71",School=schools[1],Person=persons[71],Classroom=classrooms[15],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="72",School=schools[1],Person=persons[72],Classroom=classrooms[15],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="73",School=schools[1],Person=persons[73],Classroom=classrooms[15],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="74",School=schools[1],Person=persons[74],Classroom=classrooms[15],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="75",School=schools[1],Person=persons[75],Classroom=classrooms[16],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="76",School=schools[1],Person=persons[76],Classroom=classrooms[16],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="77",School=schools[1],Person=persons[77],Classroom=classrooms[16],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="78",School=schools[1],Person=persons[78],Classroom=classrooms[17],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="79",School=schools[1],Person=persons[79],Classroom=classrooms[17],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="80",School=schools[1],Person=persons[80],Classroom=classrooms[17],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="81",School=schools[1],Person=persons[81],Classroom=classrooms[17],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="82",School=schools[1],Person=persons[82],Classroom=classrooms[17],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="83",School=schools[1],Person=persons[83],Classroom=classrooms[18],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="84",School=schools[1],Person=persons[84],Classroom=classrooms[18],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="85",School=schools[1],Person=persons[85],Classroom=classrooms[18],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="86",School=schools[1],Person=persons[86],Classroom=classrooms[18],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="87",School=schools[1],Person=persons[87],Classroom=classrooms[19],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="88",School=schools[1],Person=persons[88],Classroom=classrooms[19],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="89",School=schools[1],Person=persons[89],Classroom=classrooms[20],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="90",School=schools[1],Person=persons[90],Classroom=classrooms[20],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="91",School=schools[1],Person=persons[91],Classroom=classrooms[21],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="92",School=schools[1],Person=persons[92],Classroom=classrooms[21],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="93",School=schools[1],Person=persons[93],Classroom=classrooms[21],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="94",School=schools[1],Person=persons[94],Classroom=classrooms[22],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="95",School=schools[1],Person=persons[95],Classroom=classrooms[22],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="96",School=schools[1],Person=persons[96],Classroom=classrooms[23],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="97",School=schools[1],Person=persons[97],Classroom=classrooms[23],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="98",School=schools[1],Person=persons[98],Classroom=classrooms[23],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="99",School=schools[1],Person=persons[99],Classroom=classrooms[24],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="100",School=schools[1],Person=persons[100],Classroom=classrooms[25],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="101",School=schools[1],Person=persons[101],Classroom=classrooms[25],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="102",School=schools[1],Person=persons[102],Classroom=classrooms[25],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="103",School=schools[1],Person=persons[103],Classroom=classrooms[26],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="104",School=schools[1],Person=persons[104],Classroom=classrooms[26],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="105",School=schools[1],Person=persons[105],Classroom=classrooms[27],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="106",School=schools[1],Person=persons[106],Classroom=classrooms[27],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="107",School=schools[1],Person=persons[107],Classroom=classrooms[28],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="108",School=schools[1],Person=persons[108],Classroom=classrooms[28],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="109",School=schools[1],Person=persons[109],Classroom=classrooms[28],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now },
                new Student() {STATUS=1,SCHOOLNUMBER="110",School=schools[1],Person=persons[110],Classroom=classrooms[29],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now }
            };
            context.Students.AddRange(students);

            var lessons = new Lesson[] {
                new Lesson() {STATUS=1,Branch=brancs[0],DURATION=45,WEEKLYFREQUENCY=2,School=schools[0],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now, },
                new Lesson() {STATUS=1,Branch=brancs[1],DURATION=45,WEEKLYFREQUENCY=3,School=schools[0],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now, },
                new Lesson() {STATUS=1,Branch=brancs[2],DURATION=45,WEEKLYFREQUENCY=5,School=schools[0],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now, },
                new Lesson() {STATUS=1,Branch=brancs[3],DURATION=45,WEEKLYFREQUENCY=1,School=schools[0],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now, },
                new Lesson() {STATUS=1,Branch=brancs[4],DURATION=45,WEEKLYFREQUENCY=3,School=schools[0],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now, },
                new Lesson() {STATUS=1,Branch=brancs[5],DURATION=45,WEEKLYFREQUENCY=4,School=schools[0],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now, },
                new Lesson() {STATUS=1,Branch=brancs[0],DURATION=45,WEEKLYFREQUENCY=2,School=schools[1],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now, },
                new Lesson() {STATUS=1,Branch=brancs[1],DURATION=45,WEEKLYFREQUENCY=3,School=schools[1],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now, },
                new Lesson() {STATUS=1,Branch=brancs[2],DURATION=45,WEEKLYFREQUENCY=5,School=schools[1],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now, },
                new Lesson() {STATUS=1,Branch=brancs[3],DURATION=45,WEEKLYFREQUENCY=1,School=schools[1],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now, },
                new Lesson() {STATUS=1,Branch=brancs[4],DURATION=45,WEEKLYFREQUENCY=3,School=schools[1],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now, },
                new Lesson() {STATUS=1,Branch=brancs[5],DURATION=45,WEEKLYFREQUENCY=4,School=schools[1],CREATEDBY=99999999999,CREATIONDATE=DateTime.Now, }
            };
            context.Lessons.AddRange(lessons);

            var timeTables = new List<StudentTimeTable>();


            context.StudentTimeTables.AddRange(timeTables);

            context.SaveChanges();
        }

        private static bool IsWeekend(DateTime date)
        {
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
