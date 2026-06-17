using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zd4_KachalinSemen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            MyPicker.Items.Add("Аннуитетные");
            MyPicker.Items.Add("Дифференцированные");
            SliderPr.ValueChanged += (s, e) =>
            {
                Procent2.Text = $"{Math.Round(SliderPr.Value):F0}%";
                if (MyPicker.SelectedIndex == 0)
                {
                    LABEL1.Text = "Ежемесячный платеж: ...";
                    LABEL2.Text = $"Общая сумма: {Convert.ToInt32(SumCredit.Text) + ((Math.Round(SliderPr.Value) / 100) * Convert.ToInt32(SumCredit.Text))}";
                    LABEL3.Text = $"Переплата: {Math.Abs((Convert.ToInt32(SumCredit.Text) + ((Math.Round(SliderPr.Value) / 100) * Convert.ToInt32(SumCredit.Text)) - Convert.ToInt32(SumCredit.Text)))}";
                }
                else
                {
                    LABEL1.Text = $"Ежемесячный платеж: {Convert.ToInt32(SumCredit.Text) / 12 + (((Math.Round(SliderPr.Value) / 100) * (Convert.ToInt32(SumCredit.Text) / 12)))}";
                    LABEL2.Text = $"Общая сумма: {Convert.ToInt32(SumCredit.Text) + ((Math.Round(SliderPr.Value) / 100) * Convert.ToInt32(SumCredit.Text))}";
                    LABEL3.Text = $"Переплата: {Math.Abs((Convert.ToInt32(SumCredit.Text) + ((Math.Round(SliderPr.Value) / 100) * Convert.ToInt32(SumCredit.Text)) - Convert.ToInt32(SumCredit.Text)))}";
                }
            };
            MyPicker.SelectedIndexChanged += (s, e) =>
            {
                if(MyPicker.SelectedIndex == 0)
                {
                    LABEL1.Text = "Ежемесячный платеж: ...";
                    LABEL2.Text = $"Общая сумма: {Convert.ToInt32(SumCredit.Text) + ((Math.Round(SliderPr.Value) / 100) * Convert.ToInt32(SumCredit.Text))}";
                    LABEL3.Text = $"Переплата: {Math.Abs((Convert.ToInt32(SumCredit.Text) + ((Math.Round(SliderPr.Value) / 100) * Convert.ToInt32(SumCredit.Text)) - Convert.ToInt32(SumCredit.Text)))}";
                }
                else
                {
                    LABEL1.Text = $"Ежемесячный платеж: {Convert.ToInt32(SumCredit.Text) / 12 + (((Math.Round(SliderPr.Value) / 100) * (Convert.ToInt32(SumCredit.Text) / 12)))}";
                    LABEL2.Text = $"Общая сумма: {Convert.ToInt32(SumCredit.Text) + ((Math.Round(SliderPr.Value) / 100) * Convert.ToInt32(SumCredit.Text))}";
                    LABEL3.Text = $"Переплата: {Math.Abs((Convert.ToInt32(SumCredit.Text) + ((Math.Round(SliderPr.Value) / 100) * Convert.ToInt32(SumCredit.Text)) - Convert.ToInt32(SumCredit.Text)))}";   
                }
            };
            SumCredit.TextChanged += (s, e) =>
            {
                try
                {
                    int money = Convert.ToInt32(SumCredit.Text);
                    if (money <= 0)
                    {
                        SumCredit.Text = "";
                        SumCredit.Placeholder = "Нельзя так";
                        LABEL1.Text = "Ежемесячный платеж: ...";
                        LABEL2.Text = "Общая сумма: ...";
                        LABEL3.Text = "Переплата: ...";

                    }
                    else
                    {
                        if (MyPicker.SelectedIndex == 0)
                        {
                            LABEL1.Text = $"Ежемесячный платеж: {money / 12 + (((Math.Round(SliderPr.Value) / 100) * (money / 12)))}";
                            LABEL2.Text = $"Общая сумма: {money + ((Math.Round(SliderPr.Value) / 100)*money )}";
                            LABEL3.Text = $"Переплата: {Math.Abs((money + ((Math.Round(SliderPr.Value) / 100) * money) - money))}";
                        }
                        else
                        {
                            LABEL1.Text = "Ежемесячный платеж: ...";
                            LABEL2.Text = $"Общая сумма: {money + ((Math.Round(SliderPr.Value) / 100) * money)}";
                            LABEL3.Text = $"Переплата: {Math.Abs((money + ((Math.Round(SliderPr.Value) / 100) * money) - money))}";
                        }
                    }
                }
                catch
                {
                    SumCredit.Text = "";
                    SumCredit.Placeholder = "Нельзя так";
                    LABEL1.Text = "Ежемесячный платеж: ...";
                    LABEL2.Text = "Общая сумма: ...";
                    LABEL3.Text = "Переплата: ...";
                }
            };
            CreditM.TextChanged += (s, e) =>
            {
                try
                {
                    int money = Convert.ToInt32(CreditM.Text);
                    if (money <= 0 || money > 60)
                    {
                        CreditM.Text = "";
                        CreditM.Placeholder = "Нельзя так";
                        LABEL1.Text = "Ежемесячный платеж: ...";
                        LABEL2.Text = "Общая сумма: ...";
                        LABEL3.Text = "Переплата: ...";
                    }
                    else
                    {
                        if (MyPicker.SelectedIndex == 0)
                        {
                            LABEL1.Text = $"Ежемесячный платеж: {Convert.ToInt32(SumCredit.Text) / 12 + (((Math.Round(SliderPr.Value) / 100) * (Convert.ToInt32(SumCredit.Text) / 12)))}";
                            LABEL2.Text = $"Общая сумма: {Convert.ToInt32(SumCredit.Text) + ((Math.Round(SliderPr.Value) / 100) * Convert.ToInt32(SumCredit.Text))}";
                            LABEL3.Text = $"Переплата: {Math.Abs((Convert.ToInt32(SumCredit.Text) + ((Math.Round(SliderPr.Value) / 100) * Convert.ToInt32(SumCredit.Text)) - Convert.ToInt32(SumCredit.Text)))}";
                        }
                        else
                        {
                            LABEL1.Text = "Ежемесячный платеж: ...";
                            LABEL2.Text = $"Общая сумма: {Convert.ToInt32(SumCredit.Text) + ((Math.Round(SliderPr.Value) / 100) * Convert.ToInt32(SumCredit.Text))}";
                            LABEL3.Text = $"Переплата: {Math.Abs((Convert.ToInt32(SumCredit.Text) + ((Math.Round(SliderPr.Value) / 100) * Convert.ToInt32(SumCredit.Text)) - Convert.ToInt32(SumCredit.Text)))}";

                        }
                    }
                }
                catch
                {
                    CreditM.Text = "";
                    CreditM.Placeholder = "Нельзя так";
                    LABEL1.Text = "Ежемесячный платеж: ...";
                    LABEL2.Text = "Общая сумма: ...";
                    LABEL3.Text = "Переплата: ...";
                }
            };
        }
        
    }
}