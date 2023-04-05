using EnBibliotechDB.Entity;
using EnBibliotechDB.Logic;
using EnBibliotechDB.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnBibliotechDB
{
    public partial class AddAuthor : Form
    {
        public AddAuthor()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Entity.Entity entity = new Entity.Entity();//Создание модели базы данных
            SNP snp = new SNP();//Создание модели ФИО
            snp.surename = textBox1.Text;//Записывает данные из первого поля в фамилию 
            snp.name = textBox2.Text;//Записывает данные из второго поля в имя
            snp.patronomic = textBox3.Text;//Записывает данные из третьего поля в отчество
            entity.SNP.Add(snp);//Добавляет в базу данных ФИО
            entity.SaveChanges();//Сохраняет проделанные действия

            Person person = new Person();//Создание модели персоны
            person.adress = " ";//Заполнения поля адреса
            foreach (SNP item in entity.SNP) //Перебор фамилий для нахождения последнего добавленного
            {
                person.SNP = item;//Добавляет в персону ФИО
                person.id_SNP = item.id;//Связывает при помощи id с ФИО
            }
            entity.Person.Add(person);//Добавляет в базу данных персону
            entity.SaveChanges();//Сохраняет изменения

            entity.Person.Load();
            author author = new author();//Создание модели автора
            foreach (Person item in entity.Person)
            {
                author.Person = item;//Перебор персон для нахождения последней добавленной 
                author.id_Person = item.id;//Связывает при помощи id с персоной
                author.adress = " ";
            }//Заполнения поля адреса
            authorLogic al = new authorLogic();//Создание объекта класса отвечающего за действия над моделями авторов

            authorModel au = new authorModel();//Создание модели автора для взаимодействия
            au.Fill(author);//Перенос данных в модель для взаимодействия
            al.Add(au);//Добавление заполненной модели в базу данных
            this.Close();
        }
    }
}
