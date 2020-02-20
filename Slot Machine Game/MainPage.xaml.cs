using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Slot_Machine_Game
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int dollars;            // Variable to store the dollars
        Random number;          // Set up the random number generator
        int wheel1;			    // Variable to store the dice roll
        int wheel2;
        int wheel3;
        Boolean wheel1Clicked = false;          // Variable to store if the wheel was clicked    
        Boolean wheel2Clicked = false;          // Variable to store if the wheel was clicked        
        Boolean wheel3Clicked = false;          // Variable to store if the wheel was clicked        
        Boolean loadUp = true;                  // Sets the start up of the game

        public MainPage()
        {
            this.InitializeComponent();

            number = new Random(DateTime.Now.Millisecond); // Switch on random number generator

            buttonPlay.Visibility = Visibility.Collapsed;    // Sets the start up of the game
        }

        private void buttonAddCash_Click(object sender, RoutedEventArgs e)
        {
            dollars = dollars + 10;                                 // Add $10 to the total

            //textBlockDollars.Text = "You have $" + dollars;         // Display the dollars

            // Only allow the user to play if they have credit
            if (dollars > 0) buttonPlay.Visibility = Visibility.Visible;
        }

        private void buttonPlay_Click(object sender, RoutedEventArgs e)
        {
            // Sets the start up of the game
            if (loadUp == true)
            {
                wheel1Clicked = false;
                wheel2Clicked = false;
                wheel3Clicked = false;
                loadUp = false;
            }

            if (wheel1Clicked == false) wheel1 = number.Next(1, 7);	         // Generate a random number between 1 and 6
            if (wheel2Clicked == false) wheel2 = number.Next(1, 7);	         // Generate a random number between 1 and 6 
            if (wheel3Clicked == false) wheel3 = number.Next(1, 7);	         // Generate a random number between 1 and 6 

            dollars = dollars - 1;                                  // It costs $1 dollar to play

            if (wheel1Clicked == true) dollars = dollars - 20;      // Charge $20 to hold
            if (wheel2Clicked == true) dollars = dollars - 20;      // Charge $20 to hold
            if (wheel3Clicked == true) dollars = dollars - 20;      // Charge $20 to hold

            textBlockDollars.Text = "You have $" + dollars;         // Display the dollars


            //Wheel1
            if (wheel1Clicked == false)
            {
                if (wheel1 == 1) imageWheel1.Source = new BitmapImage(new Uri("ms-appx:///Assets/lose.png", UriKind.RelativeOrAbsolute));
                else if (wheel1 == 2) imageWheel1.Source = new BitmapImage(new Uri("ms-appx:///Assets/spade.png", UriKind.RelativeOrAbsolute));
                else if (wheel1 == 3) imageWheel1.Source = new BitmapImage(new Uri("ms-appx:///Assets/club.png", UriKind.RelativeOrAbsolute));
                else if (wheel1 == 4) imageWheel1.Source = new BitmapImage(new Uri("ms-appx:///Assets/heart.png", UriKind.RelativeOrAbsolute));
                else if (wheel1 == 5) imageWheel1.Source = new BitmapImage(new Uri("ms-appx:///Assets/diamond.png", UriKind.RelativeOrAbsolute));
                else imageWheel1.Source = new BitmapImage(new Uri("ms-appx:///Assets/win.png", UriKind.RelativeOrAbsolute));
            }

            //Wheel2   
            if (wheel2Clicked == false)
            {
                if (wheel2 == 1) imageWheel1.Source = new BitmapImage(new Uri("ms-appx:///Assets/lose.png", UriKind.RelativeOrAbsolute));
                else if (wheel2 == 2) imageWheel2.Source = new BitmapImage(new Uri("ms-appx:///Assets/spade.png", UriKind.RelativeOrAbsolute));
                else if (wheel2 == 3) imageWheel2.Source = new BitmapImage(new Uri("ms-appx:///Assets/club.png", UriKind.RelativeOrAbsolute));
                else if (wheel2 == 4) imageWheel2.Source = new BitmapImage(new Uri("ms-appx:///Assets/heart.png", UriKind.RelativeOrAbsolute));
                else if (wheel2 == 5) imageWheel2.Source = new BitmapImage(new Uri("ms-appx:///Assets/diamond.png", UriKind.RelativeOrAbsolute));
                else imageWheel2.Source = new BitmapImage(new Uri("ms-appx:///Assets/win.png", UriKind.RelativeOrAbsolute));
            }

            //Wheel3   
            if (wheel3Clicked == false)
            {
                if (wheel3 == 1) imageWheel1.Source = new BitmapImage(new Uri("ms-appx:///Assets/lose.png", UriKind.RelativeOrAbsolute));
                else if (wheel3 == 2) imageWheel3.Source = new BitmapImage(new Uri("ms-appx:///Assets/spade.png", UriKind.RelativeOrAbsolute));
                else if (wheel3 == 3) imageWheel3.Source = new BitmapImage(new Uri("ms-appx:///Assets/club.png", UriKind.RelativeOrAbsolute));
                else if (wheel3 == 4) imageWheel3.Source = new BitmapImage(new Uri("ms-appx:///Assets/heart.png", UriKind.RelativeOrAbsolute));
                else if (wheel3 == 5) imageWheel3.Source = new BitmapImage(new Uri("ms-appx:///Assets/diamond.png", UriKind.RelativeOrAbsolute));
                else imageWheel3.Source = new BitmapImage(new Uri("ms-appx:///Assets/win.png", UriKind.RelativeOrAbsolute));
            }


            // Set up the following game rules for the pay-outs
            imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/gamebackground.png",
                                                  UriKind.RelativeOrAbsolute));

            // Six – six – six: Win $60 display win image.
            if ((wheel1 == 6) && (wheel2 == 6) && (wheel3 == 6))
            {
                dollars = dollars + 60;
                imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/WinGame.png",
                                                      UriKind.RelativeOrAbsolute));
            }
            // Five – five – five: Win $50 display win image.
            if ((wheel1 == 5) && (wheel2 == 5) && (wheel3 == 5))
            {
                dollars = dollars + 50;
                imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/WinGame.png",
                                                      UriKind.RelativeOrAbsolute));
            }
            // Four – four – four: Win $40 display win image.
            if ((wheel1 == 4) && (wheel2 == 4) && (wheel3 == 4))
            {
                dollars = dollars + 40;
                imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/WinGame.png",
                                                      UriKind.RelativeOrAbsolute));
            }
            // Three – three – three: Win $30 display win image.
            if ((wheel1 == 3) && (wheel2 == 3) && (wheel3 == 3))
            {
                dollars = dollars + 30;
                imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/WinGame.png",
                                                      UriKind.RelativeOrAbsolute));
            }
            // Two – two – two: Win $20 display win image.
            if ((wheel1 == 2) && (wheel2 == 2) && (wheel3 == 2))
            {
                dollars = dollars + 20;
                imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/WinGame.png",
                                                      UriKind.RelativeOrAbsolute));
            }


            // Five – five – six: Win $10 display win image.
            if ((wheel1 == 5) && (wheel2 == 5) && (wheel3 == 6))
            {
                dollars = dollars + 10;
                imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/WinGame.png",
                                                      UriKind.RelativeOrAbsolute));
            }
            // Four – four – six: Win $8 display win image.
            if ((wheel1 == 4) && (wheel2 == 4) && (wheel3 == 6))
            {
                dollars = dollars + 8;
                imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/WinGame.png",
                                                      UriKind.RelativeOrAbsolute));
            }
            // Three – three – six: Win $6 display win image.
            if ((wheel1 == 3) && (wheel2 == 3) && (wheel3 == 6))
            {
                dollars = dollars + 6;
                imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/WinGame.png",
                                                      UriKind.RelativeOrAbsolute));
            }
            // Two – two – six: Win $4 display win image.
            if ((wheel1 == 2) && (wheel2 == 2) && (wheel3 == 6))
            {
                dollars = dollars + 4;
                imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/WinGame.png",
                                                      UriKind.RelativeOrAbsolute));
            }
            // Lose $2 for every one rolled on a wheel and display lose image.
            if (wheel1 == 1)
            {
                dollars = dollars - 2;
                imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/LoseGame.png",
                                                      UriKind.RelativeOrAbsolute));
            }
            // Lose $2 for every one rolled on a wheel and display lose image.
            if (wheel2 == 1)
            {
                dollars = dollars - 2;
                imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/LoseGame.png",
                                                      UriKind.RelativeOrAbsolute));
            }
            // Lose $2 for every one rolled on a wheel and display lose image.
            if (wheel3 == 1)
            {
                dollars = dollars - 2;
                imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/LoseGame.png",
                                                      UriKind.RelativeOrAbsolute));
            }


            wheel1Clicked = false;                 // Reset the hold after play
            imageWheel1.Opacity = 1f;              // Reset the hold brightness after play            

            wheel2Clicked = false;                 // Reset the hold after play
            imageWheel2.Opacity = 1f;              // Reset the hold brightness after play

            wheel3Clicked = false;                 // Reset the hold after play
            imageWheel3.Opacity = 1f;              // Reset the hold brightness after play


            if (dollars <= 0)
            {
                buttonPlay.Visibility = Visibility.Collapsed;
                dollars = 0;
            }
            textBlockDollars.Text = "You have $" + dollars;         // Display the dollars

        }

        private void imageWheel1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //Wheel1
            if (wheel1Clicked == false)
            {
                wheel1Clicked = true;
                imageWheel1.Opacity = 0.5f;
            }
            else
            {
                wheel1Clicked = false;
                imageWheel1.Opacity = 1f;
            }

            //Wheel2
            if (wheel2Clicked == false)
            {
                wheel2Clicked = true;
                imageWheel2.Opacity = 0.5f;
            }
            else
            {
                wheel2Clicked = false;
                imageWheel2.Opacity = 1f;
            }

            //Wheel3
            if (wheel3Clicked == false)
            {
                wheel3Clicked = true;
                imageWheel3.Opacity = 0.5f;
            }
            else
            {
                wheel3Clicked = false;
                imageWheel3.Opacity = 1f;
            }

        }
    }
}
