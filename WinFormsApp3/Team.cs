﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    public class Team
    {
        public string[] Grades = { "", "", "", "", "", ""};
        public double[] Numbers = { 0, 0, 0, 0, 0, 0 };
        public double Value = 0;
        public string Momentum = "Neutral";
        public int TimeZone = 0;


        SqlConnection conn = new SqlConnection("Data Source = LAPTOP-1IJP7QH2\\SQLEXPRESS;Initial Catalog=willdb;Integrated Security=true");
        
        public void GetDataFromDatabase(string name)
        {
            try
            {
                conn.Open();
                SqlCommand sc1 = new SqlCommand($"SELECT PG,SG,SF,PF,C,Coach,Momentum,Timezone" +
                    $" FROM Basketball_Teams WHERE Team_Name = '{name}'", conn);
                SqlDataReader reader;
                reader = sc1.ExecuteReader();
                while (reader.Read())
                {
                    for (int i = 0; i < 6; i++)
                    {
                        Grades[i] = reader.GetString(i);
                    }
                    Momentum = reader.GetString(6);
                    TimeZone = (int)reader.GetValue(7);
                }
                conn.Close();
            }
            catch
            {

            }
        }

        public void get_numbers()
        {
            string part = "";
            for (int i = 0; i < Grades.Length; i++)
            {
                if (i < 5)
                {
                    part = "Off";
                }
                if (i == 5)
                {
                    part = "Coach";
                }

                Numbers[i] = getteam(Grades[i], part);
            }

            for (int x = 0; x < Grades.Length; x++)
            {
                if (x < 5)
                {
                    Numbers[x] = Numbers[x] * Numbers[5];
                }
            }
            momenutum();
        }


        double getteam(string grade, string teampart)
        {
            double value = 0;

            switch (grade.Trim())
            {
                case "A+":
                    switch (teampart)
                    {
                        case "Off":
                            value = 15;
                            break;
                        case "Coach":
                            value = 1.7;
                            break;
                    }
                    break;
                case "A":
                    switch (teampart)
                    {
                        case "Off":
                            value = 14;
                            break;
                        case "Coach":
                            value = 1.6;
                            break;
                    }
                    break;
                case "A-":
                    switch (teampart)
                    {
                        case "Off":
                            value = 13;
                            break;
                        case "Coach":
                            value = 1.5;
                            break;
                    }
                    break;
                case "B+":
                    switch (teampart)
                    {
                        case "Off":
                            value = 12;
                            break;
                        case "Coach":
                            value = 1.4;
                            break;
                    }
                    break;
                case "B":
                    switch (teampart)
                    {
                        case "Off":
                            value = 11;
                            break;
                        case "Coach":
                            value = 1.3;
                            break;
                    }
                    break;
                case "B-":
                    switch (teampart)
                    {
                        case "Off":
                            value = 10;
                            break;
                        case "Coach":
                            value = 1.2;
                            break;
                    }
                    break;
                case "C+":
                    switch (teampart)
                    {
                        case "Off":
                            value = 9;
                            break;
                        case "Coach":
                            value = 1.1;
                            break;
                    }
                    break;
                case "C":
                    switch (teampart)
                    {
                        case "Off":
                            value = 8;
                            break;
                        case "Coach":
                            value = 1;
                            break;
                    }
                    break;
                case "C-":
                    switch (teampart)
                    {
                        case "Off":
                            value = 7;
                            break;
                        case "Coach":
                            value = 0.9;
                            break;
                    }
                    break;
                case "D+":
                    switch (teampart)
                    {
                        case "Off":
                            value = 6;
                            break;
                        case "Coach":
                            value = 0.85;
                            break;
                    }
                    break;
                case "D":
                    switch (teampart)
                    {
                        case "Off":
                            value = 5;
                            break;
                        case "Coach":
                            value = 0.8;
                            break;
                    }
                    break;
                case "D-":
                    switch (teampart)
                    {
                        case "Off":
                            value = 4;
                            break;
                        case "Coach":
                            value = 0.75;
                            break;
                    }
                    break;
                case "F":
                    switch (teampart)
                    {
                        case "Off":
                            value = 3;
                            break;
                        case "Coach":
                            value = 0.7;
                            break;
                    }
                    break;
            }
            return value;
        }

        public void getvalue()
        {
            double sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum = sum + Numbers[i];
            }
            Value = sum;
        }

        public void momenutum()
        {
            Momentum = Momentum.Trim();

            double boost = 0;
            switch (Momentum)
            {
                case "Very Good":
                    boost = 1.3;
                    break;
                case "Good":
                    boost = 1.1;
                    break;
                case "Neutral":
                    boost = 1;
                    break;
                case "Bad":
                    boost = 0.9;
                    break;
                case "Low":
                    boost = 0.75;
                    break;
            }

            for (int x = 0; x < Grades.Length; x++)
            {
                if (x < 5)
                {
                    Numbers[x] = Numbers[x] * boost;
                }
            }
        }

        public void Away_Travel(int time)
        {
            double boost = 0;
            switch (time)
            {
                case -1:
                    boost = 1;
                    break;
                case 0:
                    boost= 0.95;
                    break;
                case 1:
                    boost = 0.9;
                    break;
                case 2:
                    boost = 0.85;
                    break;
                case 3:
                    boost = 0.8;
                    break;
            }

            for (int x = 0; x < Grades.Length; x++)
            {
                if (x < 5)
                {
                    Numbers[x] = Numbers[x] * boost;
                }
            }
        }
    }
}
