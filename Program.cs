﻿using System;
using System.Collections.Generic;
using cse210_greed.Game.Casting;
using cse210_greed.Game.Directing;
using cse210_greed.Game.Services;



namespace cse210_greed
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    class Program
    {
        private static int FRAME_RATE = 12;
        private static int MAX_X = 900;
        private static int MAX_Y = 600;
        private static int CELL_SIZE = 15;
        private static int FONT_SIZE = 15;
        private static int COLS = 60;
        private static int ROWS = 40;
        private static string CAPTION = "Greed";
        private static Color WHITE = new Color(255, 255, 255, 255);
        private static Color BANNER_WHITE = new Color(255, 255, 255, 150);
        private static int DEFAULT_GEMS = 20;
        private static int DEFAULT_ROCKS = 20;

        /// <summary>
        /// /// 
        /// </summary>
        /// /// <param name="args"></param>
        static void Main(string[] args)
        {
            //create the cast
            Cast cast = new Cast();

            //create the banner
            Actor scoreBanner = new Actor();
            scoreBanner.SetText("");
            scoreBanner.SetFontSize(FONT_SIZE);
            scoreBanner.SetColor(BANNER_WHITE);
            scoreBanner.SetPosition(new Location(CELL_SIZE, 0));
            cast.AddActor("banner", scoreBanner);

            Actor dialogueBanner = new Actor();
            banner.SetText("");
            banner.SetFontSize(FONT_SIZE);
            banner.SetColor(BANNER_WHITE);
            banner.SetPosition(new Location(CELL_SIZE, 0));
            cast.AddActor("banner", banner);

            //create the robot
            Actor robot = new Actor();
            robot.SetText("#");
            robot.SetFontSize(FONT_SIZE);
            banner.SetColor(WHITE);
            banner.SetPosition(new Location(MAX_X / 2, MAX_Y));
            cast.AddActor("robot", robot);

            //create the gems
            Random random = new Random();
            for (int i = 0; i < DEFAULT_GEMS; i++){

                int x = random.Next(1, COLS);
                int y = 1;
                Location position = new Location(x, y);
                position = position.Scale(CELL_SIZE);

                int r = random.Next(0, 256);
                int g = random.Next(0, 256);
                int b = random.Next(0, 256);
                int a = random.Next(200, 256);
                Color color = new Color(r, g, b, a);

                Artifact artifact = new Artifact();
                artifact.SetText("O");
                artifact.SetFontSize(FONT_SIZE);
                artifact.SetColor(color);
                artifact.SetPosition(position);
                artifact.SetMessage("gem");
                cast.AddActor("artifacts", artifact);
            }
            
            //create the rocks
            for (int i = 0; i < DEFAULT_ROCKS; i++){
                 int x = random.Next(1, COLS);
                int y = 1;
                Location position = new Location(x, y);
                position = position.Scale(CELL_SIZE);

                int r = random.Next(0, 256);
                int g = random.Next(0, 256);
                int b = random.Next(0, 256);
                int a = 255;
                Color color = new Color(r, g, b, a);

                Artifact artifact = new Artifact();
                artifact.SetText("O");
                artifact.SetFontSize(FONT_SIZE);
                artifact.SetColor(color);
                artifact.SetPosition(position);
                artifact.SetMessage("rocks");
                cast.AddActor("artifacts", artifact);
                
            }
        }
    }