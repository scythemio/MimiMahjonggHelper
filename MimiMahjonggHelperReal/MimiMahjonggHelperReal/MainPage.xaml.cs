using Microsoft.Maui.Controls;
using Microsoft.Maui.Media;
using System.Collections.ObjectModel;
using System.Linq;

namespace MimiMahJonggHelperReal
{
    public class SpecificHand
    {
        public string? HandName { get; set; }
        public string? SpokenContent { get; set; }
    }

    public class MahjonggCategory
    {
        public string? CategoryName { get; set; }
        public List<SpecificHand> Hands { get; set; } = new List<SpecificHand>();
    }

    public partial class MainPage : ContentPage
    {
        private List<MahjonggCategory> allMahjonggCategories = new List<MahjonggCategory>();

        public MainPage()
        {
            InitializeComponent();
            LoadMahjonggData();
            SetInitialThemeRadioButtonState();
        }

        private void LoadMahjonggData()
        {
            allMahjonggCategories = new List<MahjonggCategory>
            {
                new MahjonggCategory
                {
                    CategoryName = "SNA KKKK E BIT",
                    Hands = new List<SpecificHand>
                    {
                        new SpecificHand { HandName = "222 4 6 888 444 666 (3 suits)", SpokenContent = "A Pung of twos, a single four, a single six, a Pung of eights, a Pung of fours, and a Pung of sixes. This hand uses three suits. Twenty-five points." },
                        new SpecificHand { HandName = "222 444 25 666 888 (1-3 suits)", SpokenContent = "A Pung of twos, a Pung of fours, a single two, a single five, a Pung of sixes, and a Pung of eights. This hand uses one or three suits. Twenty-five points." },
                        new SpecificHand { HandName = "AS KKKK 4 A 2 22 222 (Any tile, K any Kong, any same even, 3 suits)", SpokenContent = "The letters A S, a Kong of any identical tile, a single four, the letter A, a single two, a Pair of twos, and a Pung of twos. This hand uses any tile, any Kong, and any same even-numbered tiles, across three suits. Twenty-five points." },
                        new SpecificHand { HandName = "FF 444 DDD 888 EEE (Any 2 diff evens, 2 suits, any D, any Wind)", SpokenContent = "A Pair of Flowers, a Pung of fours, a Pung of Dragon tiles, a Pung of eights, and a Pung of East Wind tiles. This hand uses any two different even-numbered tiles, across two suits, any Dragon, and any Wind. Twenty-five points." },
                        new SpecificHand { HandName = "MJ PPP KKKK 666 88 (M=W, J=Joker, P any Pung, K any Kong, #s-1 suit)", SpokenContent = "A Mahjongg tile, a Pung of any identical tiles, a Kong of any identical tiles, a Pung of sixes, and a Pair of eights. For this hand, M stands for Winds, J stands for Joker, P is any Pung, K is any Kong, and Numbers are in one suit. Thirty-five points." },
                        new SpecificHand { HandName = "FFF 2468 PPP 2468 (2 suits, P any Pung)", SpokenContent = "A Pung of Flowers, a two, a four, a six, and an eight, followed by a Pung of any identical tiles, then another two, four, six, and eight. This hand uses two suits, and P is any Pung. Thirty-five points." },
                        new SpecificHand { HandName = "CLEO PPP A 222 R AA (Any C, L=7, P any Pung, A any tile, AA any Pr)", SpokenContent = "The letters C L E O, a Pung of any identical tiles, the letter A, a Pung of twos, the letter R, and a Pair of the letter A tiles. For this hand, C is any Craks tile, L stands for the number seven tile, P is any Pung, A is any tile, and A A is any Pair. Forty points." }
                    }
                },
                new MahjonggCategory
                {
                    CategoryName = "SNA KKKK E EYES",
                    Hands = new List<SpecificHand>
                    {
                        new SpecificHand { HandName = "F 1 333 555 999 999 (3 suits)", SpokenContent = "One Flower, a single one, a Pung of threes, a Pung of fives, and two Pungs of nines. This hand uses three suits. Twenty-five points." },
                        new SpecificHand { HandName = "111 333 25 777 999 (1-3 suits)", SpokenContent = "A Pung of ones, a Pung of threes, a single two, a single five, a Pung of sevens, and a Pung of nines. This hand uses one or three suits. Twenty-five points." },
                        new SpecificHand { HandName = "AS KKKK 4 A 5 55 555 (Any tile, K any Kong, any same odd, 3 suits)", SpokenContent = "The letters A S, a Kong of any identical tile, a single four, the letter A, a single five, and two Pungs of fives. This hand uses any tile, any Kong, and any same odd-numbered tiles, across three suits. Twenty-five points." },
                        new SpecificHand { HandName = "FF 333 DDD 777 NNN (any two diff odds, 2 suits, any D, any Wind)", SpokenContent = "A Pair of Flowers, a Pung of threes, a Pung of Dragon tiles, a Pung of sevens, and a Pung of North Wind tiles. This hand uses any two different odd-numbered tiles, across two suits, any Dragon, and any Wind. Twenty-five points." },
                        new SpecificHand { HandName = "MJ PPP KKKK 333 55 (M=W, J=Joker, P any Pung, K any Kong, #s-1 suit)", SpokenContent = "A Mahjongg tile, a Pung of any identical tiles, a Kong of any identical tiles, a Pung of threes, and a Pair of fives. For this hand, M stands for Winds, J stands for Joker, P is any Pung, K is any Kong, and Numbers are in one suit. Thirty-five points." },
                        new SpecificHand { HandName = "F 13579 PPP 13579 (2 suits, P any Pung)", SpokenContent = "One Flower, a one, a three, a five, a seven, and a nine, followed by a Pung of any identical tiles, then another one, three, five, seven, and nine. This hand uses two suits, and P is any Pung. Thirty-five points." },
                        new SpecificHand { HandName = "RO LLL I PPP O LLL I (I=1, P any Pung, 7 Pungs-2 suits)", SpokenContent = "The letters R O, a Pung of the letter L tiles, the letter I, a Pung of any identical tiles, another Pung of the letter O tiles, another Pung of the letter L tiles, and the letter I. For this hand, I stands for the number one tile, P is any Pung, and this hand consists of seven Pungs across two suits. Forty points." },
                        new SpecificHand { HandName = "ATOMIC – A2OMIC 22 77 33 55", SpokenContent = "Atomic Hand, A, two, O, M, I, C: a Pair of twos, a Pair of sevens, a Pair of threes, and a Pair of fives. For this hand, A is any tile, M stands for Winds, I stands for the number one tile, C is any Craks tile, and it uses any four different numbered Pairs. Thirty-five points." },
                        new SpecificHand { HandName = "SUB ATOMIC – A123456789 2025", SpokenContent = "Sub Atomic Hand: The letter A, followed by a run of one, two, three, four, five, six, seven, eight, nine, and the year two zero two five. This hand is a run in one suit, with a tricolor year. Forty points, c." }
                    }
                },
                new MahjonggCategory
                {
                    CategoryName = "DEAD RINGER",
                    Hands = new List<SpecificHand>
                    {
                        new SpecificHand { HandName = "FFF AA NNN GGG SSS (AA any pair)", SpokenContent = "A Pung of Flowers, a Pair of the letter A tiles, a Pung of North Wind tiles, a Pung of Green Dragon tiles, and a Pung of South Wind tiles. The letters A A represent any Pair. Twenty-five points." },
                        new SpecificHand { HandName = "E KKKK A SNA KKKK E (K any Kong A any tile)", SpokenContent = "East Wind tile, a Kong of any identical tile, the letter A, the letters S N A, another Kong of any identical tile, and an East Wind tile. For this hand, K is any Kong, and A is any tile. Twenty-five points." },
                        new SpecificHand { HandName = "SLI PPP N SLI DDD E (L=7,I=1,P any Pung,D any Pung)", SpokenContent = "The letters S L I, a Pung of any identical tiles, a North Wind tile, the letters S L I again, a Pung of Dragon tiles, and an East Wind tile. For this hand, L stands for the number seven tile, I stands for the number one tile, P is any Pung, and D is any Pung of Dragons. Thirty points." },
                        new SpecificHand { HandName = "L II MMM B L EEE SSS (L=7,I=1,Pr,M=W B any Bam)", SpokenContent = "The letter L, two of the letter I tiles, a Pung of Mahjongg tiles, a Bams tile, the letter L, a Pung of East Wind tiles, and a Pung of South Wind tiles. For this hand, L stands for the number seven tile, I stands for the number one tile Pair, M stands for Winds, and B is any Bams tile. Thirty points." },
                        new SpecificHand { HandName = "AA SN AA KKKK E BI2 (AA any Pr,K any Kong,B any Bam,I=1)", SpokenContent = "A Pair of the letter A tiles, the letters S N, another Pair of the letter A tiles, a Kong of any identical tile, an East Wind tile, a Bams tile, and the number one, two. The letters A A represent any Pair, K is any Kong, B is any Bams tile, and I stands for the number one tile. Thirty-five points." },
                        new SpecificHand { HandName = "SER PPP II N 22 INE (P any Pung,I=1 Pr,2 Pr,#s 1or2 suits)", SpokenContent = "The letters S E R, a Pung of any identical tiles, two of the letter I tiles, a North Wind tile, a Pair of twos, the letters I N E. For this hand, P is any Pung, I stands for the number one tile Pair, and numbers are in one or two suits. Forty points." },
                        new SpecificHand { HandName = "A COLD KKKK I LL ER (A any tile,C any C,L=7,D any D,K any K,I=1,7 Pr)", SpokenContent = "The letter A, the word COLD, a Kong of any identical tile, the letter I, a Pair of the letter L tiles, and the letters E R. For this hand, A is any tile, C is any Craks tile, L stands for the number seven tile, D is any Dragon tile, K is any Kong, I stands for the number one tile, and this hand uses a seven Pair. Forty points." }
                    }
                },
                new MahjonggCategory
                {
                    CategoryName = "SNA KKKK E CHARMER",
                    Hands = new List<SpecificHand>
                    {
                        new SpecificHand { HandName = "333 6 9999 3 6666 9 (2 suits)", SpokenContent = "A Pung of threes, a single six, a Kong of nines, a single three, a Kong of sixes, and a single nine. This hand uses two suits. Twenty-five points." },
                        new SpecificHand { HandName = "6 333 WWW DDD 999 6 (#s 1-3 suits, any W P, any D P)", SpokenContent = "A single six, a Pung of threes, a Pung of West Wind tiles, a Pung of Dragon tiles, a Pung of nines, and a single six. This hand uses numbers in one or three suits, any Wind Pung, and any Dragon Pung. Twenty-five points." },
                        new SpecificHand { HandName = "2025 PPP 3 666 999 (Tricolor yr, P any P, #s 1 suit)", SpokenContent = "The year two zero two five, a Pung of any identical tiles, a Pung of threes, a Pung of sixes, and a Pung of nines. This hand uses a tricolor year, P is any Pung, and numbers are in one suit. Thirty-five points." },
                        new SpecificHand { HandName = "MJ KKKK 33 666 999 (M=W,J=Joker,K=K, 1or3 suits)", SpokenContent = "A Mahjongg tile, a Joker tile, a Kong of any identical tile, a Pair of threes, a Pung of sixes, and a Pung of nines. For this hand, M stands for Winds, J stands for Joker, K is a Kong, and this hand uses one or three suits. Thirty-five points." },
                        new SpecificHand { HandName = "MAMBA 333 666 999 (M=W,A any tile,B any Bam,#s 1or3 suits)", SpokenContent = "The word MAMBA: a Pung of threes, a Pung of sixes, and a Pung of nines. For this hand, M stands for Winds, A is any tile, B is any Bams tile, and numbers are in one or three suits. Thirty-five points." }
                    }
                },
                 new MahjonggCategory
                {
                    CategoryName = "DO THE NUMBERS",
                    Hands = new List<SpecificHand>
                    {
                        new SpecificHand { HandName = "FF 222 555 999 999 (3 suits)", SpokenContent = "A Pair of Flowers, a Pung of twos, a Pung of fives, and two Pungs of nines. This hand uses three suits. Twenty-five points." },
                        new SpecificHand { HandName = "FFFF 888 888 9999 (3 suits)", SpokenContent = "A Kong of Flowers, two Pungs of eights, and a Kong of nines. This hand uses three suits. Twenty-five points." },
                        new SpecificHand { HandName = "FF 444 5555 666 10 (1-3 suits)", SpokenContent = "A Pair of Flowers, a Pung of fours, a Kong of fives, a Pung of sixes, and the number ten. This hand uses one or three suits. Twenty-five points." },
                        new SpecificHand { HandName = "45.2543 N 36.2145 E (#s any suits)", SpokenContent = "The numbers four five point two five four three North, and three six point two one four five East. These are numbers in any suit, representing the Longitude and Latitude of Snake Island, Brazil. Twenty-five points, c." }
                    }
                },
                new MahjonggCategory
                {
                    CategoryName = "ON THE STRAIGHT AND NARROW",
                    Hands = new List<SpecificHand>
                    {
                        new SpecificHand { HandName = "22 333 4444 55 666 (Any consec run, 1or3 suits)", SpokenContent = "A Pair of twos, a Pung of threes, a Kong of fours, a Pair of fives, and a Pung of sixes. This is any consecutive run, in one or three suits. Twenty-five points." },
                        new SpecificHand { HandName = "1 222 3 4 555 6 7 888 (Any consec run, 1or3 suits)", SpokenContent = "A single one, a Pung of twos, a single three, a single four, a Pung of fives, a single six, a single seven, and a Pung of eights. This is any consecutive run, in one or three suits. Twenty-five points." },
                        new SpecificHand { HandName = "20 777 EEE 9999 25 (3 suits, any int. run, any Wind)", SpokenContent = "The number twenty, a Pung of sevens, a Pung of East Wind tiles, a Kong of nines, and the number twenty-five. This hand uses three suits, any integer run, and any Wind. Thirty points." },
                        new SpecificHand { HandName = "AA 111222333444 (AA any Pr, any consec run, 3 suits)", SpokenContent = "A Pair of the letter A tiles, a Pung of ones, a Pung of twos, a Pung of threes, and a Pung of fours. The letters A A represent any Pair, and this is any consecutive run across three suits. Thirty points." },
                        new SpecificHand { HandName = "MJ 111 PPP 333 444 (M=W,J=Joker any Pr#,...)", SpokenContent = "A Mahjongg tile, a Joker tile, a Pung of ones, a Pung of any identical tiles, a Pung of threes, and a Pung of fours. For this hand, M stands for Winds, J stands for Joker any progressive number, this hand uses one or three suits, and P is any Pung. Thirty-five points." },
                        new SpecificHand { HandName = "KKKK 12345 12345 (K any Kong, any same consec run 2 suits)", SpokenContent = "A Kong of any identical tile, a run of one, two, three, four, five, and another run of one, two, three, four, five. For this hand, K is any Kong, and this is any same consecutive run in two suits. Thirty-five points." },
                        new SpecificHand { HandName = "NEWS 0 2468 13579 (2 suits)", SpokenContent = "The word NEWS, a White Dragon tile, a run of two, four, six, eight, and a run of one, three, five, seven, nine. This hand uses two suits. Forty points." }
                    }
                },
                new MahjonggCategory
                {
                    CategoryName = "ANACONDA",
                    Hands = new List<SpecificHand>
                    {
                        new SpecificHand { HandName = "QQQQQ WIC KKKK LI (Q any Quint,I=1,C any C,K any K,L=7)", SpokenContent = "A Quint of the letter Q tiles, the letters W I C, a Kong of any identical tile, and the letters L I. For this hand, Q is any Quint, I stands for the number one tile, C is any Craks tile, K is any Kong, and L stands for the number seven tile. Thirty-five points." },
                        new SpecificHand { HandName = "BBB CCC DE FFFFF (B any Bam P,C any Crac P,D any D)", SpokenContent = "A Pung of Bams tiles, a Pung of Craks tiles, a Dragon tile, an East Wind tile, and a Quint of Flower tiles. For this hand, B is any Bams Pung, C is any Craks Pung, and D is any Dragon. Thirty-five points." },
                        new SpecificHand { HandName = "45678 99999 10 11 1 (1or2 suits)", SpokenContent = "A run of four, five, six, seven, eight, a Quint of nines, the number ten, the number eleven, and a single one. This hand uses one or two suits. Forty points." },
                        new SpecificHand { HandName = "AA QQQQQ AA QQQQQ (AA any Pr, Q any Quint)", SpokenContent = "A Pair of the letter A tiles, a Quint of the letter Q tiles, another Pair of the letter A tiles, and another Quint of the letter Q tiles. The letters A A represent any Pair, and Q is any Quint. Forty points." },
                        new SpecificHand { HandName = "55555 X 55555 IS 25 (3 suits, I=1)", SpokenContent = "A Quint of fives, the letter X, another Quint of fives, the letters I S, and the number twenty-five. This hand uses three suits, and I stands for the number one tile. Forty points." },
                        new SpecificHand { HandName = "AA NA CCCCC OND AA (AA any Pr,A any tile,C any C Q, D any D)", SpokenContent = "A Pair of the letter A tiles, the letters N A, a Quint of Craks tiles, the letters O N D, and another Pair of the letter A tiles. The letters A A represent any Pair, A is any tile, C is any Craks Quint, and D is any Dragon. Fifty points." }
                    }
                },
                new MahjonggCategory
                {
                    CategoryName = "MJ ANTIDOTE",
                    Hands = new List<SpecificHand>
                    {
                        new SpecificHand { HandName = "R AA ND BL AA C KKKK (AA any Pr,D any D,B any Bam,L=7,C any C,K any K)", SpokenContent = "The letter R, a Pair of the letter A tiles, the letters N D, a Bams tile, the letter L, another Pair of the letter A tiles, a Craks tile, and a Kong of any identical tile. The letters A A represent any Pair, D is any Dragon, B is any Bams tile, L stands for the number seven tile, C is any Craks tile, and K is any Kong. Fifty points." },
                        new SpecificHand { HandName = "DIAMOND BAC KKKK (D any D,I=1,A any tile M=W,B any B,C any C,K any K)", SpokenContent = "The word DIAMOND, a Bams tile, the letter A, a Craks tile, and a Kong of any identical tile. For this hand, D is any Dragon, I stands for the number one tile, A is any tile, M stands for Winds, B is any Bams tile, C is any Craks tile, and K is any Kong. Thirty points." },
                        new SpecificHand { HandName = "JM PPP AND SCREAM (J=Joker,M=W,PPP any P,A any tile,D any D,C any C)", SpokenContent = "The letters J M, a Pung of any identical tiles, the word AND, and the word SCREAM. For this hand, J stands for Joker, M stands for Winds, PPP is any Pung, A is any tile, D is any Dragon, and C is any Craks tile. Fifty points." },
                        new SpecificHand { HandName = "MMJ IS FN 2 PPP L AA (M=W,J=Joker,I=1 P any P,L=7,AA any Pair)", SpokenContent = "Two Mahjongg tiles, a Joker tile, the letters I S, a Flower tile, a North Wind tile, a single two, a Pung of any identical tiles, the letter L, and a Pair of the letter A tiles. For this hand, M stands for Winds, J stands for Joker, I stands for the number one tile, P is any Pung, L stands for the number seven tile, and A A is any Pair. Fifty points." },
                        new SpecificHand { HandName = "BILD A WALL FOR MJ (B any Bam,I=1,L=7 D any D,A any tile,M=W,J=Joker)", SpokenContent = "The phrase BUILD A WALL FOR MJ. For this hand, B is any Bams tile, I stands for the number one tile, L stands for the number seven tile, D is any Dragon tile, A is any tile, M stands for Winds, and J stands for Joker. Seventy-five points, c." },
                        new SpecificHand { HandName = "BOA CONS2RIC2OR (B any Bam,A any tile,C any C,I=1)", SpokenContent = "The phrase BOA CONS2RIC2OR. For this hand, B is any Bams tile, A is any tile, C is any Craks tile, and I stands for the number one tile. Seventy-five points, c." },
                        new SpecificHand { HandName = "MEDICINE SIMBOL (M=W,D any D,I=1 C any C,I=1 N E S I M B O L=7)", SpokenContent = "The phrase MEDICINE SIMBOL. For this hand, M stands for Winds, D is any Dragon tile, I stands for the number one tile, C is any Craks tile, I stands for the number one tile, N is any North Wind tile, E is any East Wind tile, S is any South Wind tile, I stands for the number one tile, M stands for Winds, B is any Bams tile, O is a White Dragon tile (Soap), and L stands for the number seven tile. Seventy-five points, c." }
                    }
                }
            };
        }

        private async void OnMahjonggCategoryClicked(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                var category = allMahjonggCategories.FirstOrDefault(cat => cat.CategoryName == clickedButton.Text);

                if (category != null && category.Hands != null && category.Hands.Any())
                {
                    if (string.IsNullOrEmpty(category.CategoryName))
                    {
                        await DisplayAlert("Error", "Category name is missing.", "OK");
                        return;
                    }
                    await Navigation.PushAsync(new HandSelectionPage(category.Hands, category.CategoryName));
                }
                else
                {
                    await DisplayAlert("Not Found", "Details for this category are not available or it has no hands.", "OK");
                }
            }
        }

        private void ThemeRadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (!e.Value)
                return;

            AppTheme newTheme = AppTheme.Unspecified;

            if (sender == LightModeRadio)
                newTheme = AppTheme.Light;
            else if (sender == DarkModeRadio)
                newTheme = AppTheme.Dark;

            if (Microsoft.Maui.Controls.Application.Current != null)
            {
                Microsoft.Maui.Controls.Application.Current.UserAppTheme = newTheme;
            }
        }

        private void SetInitialThemeRadioButtonState()
        {
            if (Microsoft.Maui.Controls.Application.Current == null) return;

            if (Microsoft.Maui.Controls.Application.Current.UserAppTheme == AppTheme.Light)
            {
                LightModeRadio.IsChecked = true;
            }
            else if (Microsoft.Maui.Controls.Application.Current.UserAppTheme == AppTheme.Dark)
            {
                DarkModeRadio.IsChecked = true;
            }
            else
            {
                SystemModeRadio.IsChecked = true;
            }
        }
    }
}