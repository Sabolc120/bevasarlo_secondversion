using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bevasarlo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Random veletlen = new Random();
            int kivalaszto = veletlen.Next(1, 4);
            string uzenet1 = "Fáradtság legjobb gyógymódja az a szemétkaja!";
            string uzenet2 = "Majd ledolgozod a felesleges kalóirát!";
            string uzenet3 = "Szellemi munka? Szénhidrát a válasz!";
            PayItemsButton.Enabled = false;
            if (kivalaszto == 1)
            {
                dailyLuckytext.Text = uzenet1;
            }
            if (kivalaszto == 2)
            {
                dailyLuckytext.Text = uzenet2;
            }
            if (kivalaszto == 3)
            {
                dailyLuckytext.Text = uzenet3;
            }
        }
        private void addToBasketButton_Click(object sender, EventArgs e)
        {
            backMoneyNumeric.Value = 0;
            prices arak = new prices();
            shopitems targyak = new shopitems();
            counter szamlalo = new counter();
            targyak.Fagyasztott_pizza = freezedPizzaCheckbox.Text;
            targyak.Tablacsoki = chocolateCheckbox.Text;
            targyak.Gumicukor = gummybearCheckbox.Text;
            targyak.Snack_leves = snackSoupCheckbox.Text;
            szamlalo.SnacksoupQuantity = snackSoupNumeric.Value;
            szamlalo.ChocoQuantity = chocolateNumeric.Value;
            szamlalo.FreezedpizzaQuantity = freezedPizzaNumeric.Value;
            szamlalo.GummybearQuantity = gummybearNumeric.Value;
            if (chocolateCheckbox.Checked == true)
            {
                shoppingList.Items.Add(targyak.Tablacsoki);
                shoppingList.Items.Add(szamlalo.ChocoQuantity * arak.Chocoprice);
                shoppingList.Items.Add(szamlalo.ChocoQuantity + " darab");
                shoppingList.Items.Add("-------------------");
                overallMoney.Value += arak.Chocoprice * szamlalo.ChocoQuantity;

            }
            if (gummybearCheckbox.Checked == true)
            {
                shoppingList.Items.Add(targyak.Gumicukor);
                shoppingList.Items.Add(szamlalo.GummybearQuantity * arak.GummybearPrice);
                shoppingList.Items.Add(szamlalo.GummybearQuantity + " darab");
                shoppingList.Items.Add("-------------------");
                overallMoney.Value += arak.GummybearPrice * szamlalo.GummybearQuantity;

            }
            if (snackSoupCheckbox.Checked == true)
            {
                shoppingList.Items.Add(targyak.Snack_leves);
                shoppingList.Items.Add(szamlalo.SnacksoupQuantity * arak.SnackSoup);
                shoppingList.Items.Add(szamlalo.SnacksoupQuantity + " darab");
                shoppingList.Items.Add("-------------------");
                overallMoney.Value += arak.SnackSoup * szamlalo.SnacksoupQuantity;

            }
            if (freezedPizzaCheckbox.Checked == true)
            {
                shoppingList.Items.Add(targyak.Fagyasztott_pizza);
                shoppingList.Items.Add(szamlalo.FreezedpizzaQuantity * arak.FreezedPizza);
                shoppingList.Items.Add(szamlalo.FreezedpizzaQuantity + " darab");
                shoppingList.Items.Add("-------------------");
                overallMoney.Value += arak.FreezedPizza * szamlalo.FreezedpizzaQuantity;

            }
            addToBasketButton.Enabled = false;
        }
        private void clearItemsbutton_Click(object sender, EventArgs e)
        {
            shoppingList.Items.Clear();
            moneyCounter.Value = 0;
            overallMoney.Value = 0;
            addToBasketButton.Enabled = true;
            backMoneyNumeric.Value = 0;

        }

        private void payButton_Click(object sender, EventArgs e)
        {
            moneycounter penzszamlalo = new moneycounter();
            pay fizetes = new pay();
            penzszamlalo.Tizforintszam = teenNumeric.Value;
            penzszamlalo.Otszazforintszam = fivehundredNumeric.Value;
            penzszamlalo.Szazforintszam = onehundredNumeric.Value;
            penzszamlalo.Ezerforintszam = onethousandNumeric.Value;
            penzszamlalo.Tizezerforintszam = teenthousandNumeric.Value;
            penzszamlalo.Ketezerforintszam = twothousandNumeric.Value;
            if (teenCheckbox.Checked == true)
            {
                moneyCounter.Value += penzszamlalo.Tizforintszam * fizetes.Tizforint;
            }
            if (hundredCheckbox.Checked == true)
            {
                moneyCounter.Value += penzszamlalo.Szazforintszam * fizetes.Szazforint;
            }
            if (fivehundredCheckbox.Checked == true)
            {
                moneyCounter.Value += penzszamlalo.Otszazforintszam * fizetes.Otszazforint;
            }
            if (onethousandCheckbox.Checked == true)
            {
                moneyCounter.Value += penzszamlalo.Ezerforintszam * fizetes.Ezerforint;
            }
            if (twothousandCheckbox.Checked == true)
            {
                moneyCounter.Value += penzszamlalo.Ketezerforintszam * fizetes.Ketezerforint;
            }
            if (teenthousandCheckbox.Checked == true)
            {
                moneyCounter.Value += penzszamlalo.Tizezerforintszam * fizetes.Tizezerforint;
            }
            PayItemsButton.Enabled = true;
        }

        private void backMoneyNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PayItemsButton_Click(object sender, EventArgs e)
        {
            backMoneyNumeric.Value = moneyCounter.Value - overallMoney.Value;
            if (backMoneyNumeric.Value < 0)
            {
                shoppingList.Items.Clear();
                moneyCounter.Value = 0;
                overallMoney.Value = 0;
                addToBasketButton.Enabled = true;
                backMoneyNumeric.Value = 0;
                MessageBox.Show("Nem elegendő pénz!");
            }
            else
            {
                shoppingList.Items.Clear();
                moneyCounter.Value = 0;
                overallMoney.Value = 0;
                addToBasketButton.Enabled = true;
                MessageBox.Show("Köszönjük a vásárlást!");
            }
        }
    }
}
        
