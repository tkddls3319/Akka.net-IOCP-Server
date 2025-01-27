﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyClient
{
    internal class Util
    {
        static List<(string sender, string message, string time)> _chatLogs = new List<(string, string, string)>();

        public static void AddDisplayMessage(string message, string sender = "", string time = "")
        {
            _chatLogs.Add((sender, message, time));
        }
        public static void AddOrPrintDisplayMessage(string message, string sender = "", string time = "")
        {
            AddDisplayMessage(message, sender, time);
            DisplayChat();
        }
        public static void PrintDisplayMessage()
        {
            DisplayChat();
        }
        public static void DisplayChat()
        {
            Console.Clear();

            foreach (var (sender, message, time) in _chatLogs)
            {
                if (sender == Program.AccountName)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    PrintRightAligned($"[나] {message}", 10);
                    PrintRightAligned($"{time}", 10);
                    Console.WriteLine(new string('-', Console.WindowWidth)); // 구분선
                }
                else if (string.IsNullOrEmpty(sender) == false)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    PrintLeftAligned($"[{sender}] {message}");
                    PrintLeftAligned($"{time}");
                    Console.WriteLine(new string('-', Console.WindowWidth)); // 구분선
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    PrintLeftAligned($"{message}");
                }
            }
            Console.ResetColor();
        }
        static void PrintRightAligned(string text, int padding)
        {
            int maxWidth = Console.WindowWidth - padding;
            var lines = WrapText(text, maxWidth);
            foreach (var line in lines)
            {
                int position = Math.Max(0, Console.WindowWidth - line.Length - padding);
                Console.SetCursorPosition(position, Console.CursorTop);
                Console.WriteLine(line);
            }
        }
        static void PrintLeftAligned(string text)
        {
            int maxWidth = Console.WindowWidth;
            var lines = WrapText(text, maxWidth);
            foreach (var line in lines)
            {
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.WriteLine(line);
            }
        }
        static List<string> WrapText(string text, int maxWidth)
        {
            var lines = new List<string>();
            while (text.Length > maxWidth)
            {
                int splitIndex = text.LastIndexOf(' ', maxWidth); // 줄바꿈 위치 찾기
                if (splitIndex == -1) splitIndex = maxWidth; // 공백 없으면 강제로 자르기
                lines.Add(text.Substring(0, splitIndex).Trim());
                text = text.Substring(splitIndex).Trim();
            }
            lines.Add(text); // 마지막 줄 추가
            return lines;
        }
        public static void DrawBox(string title, string[] options, int selectedIndex)
        {
            int width = Console.WindowWidth;
            int boxWidth = 40;
            int boxHeight = options.Length + 4;

            int left = (width - boxWidth) / 2;
            int top = 3;

            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < boxHeight; i++)
            {
                Console.SetCursorPosition(left, top + i);
                if (i == 0 || i == boxHeight - 1)
                {
                    Console.WriteLine(new string('-', boxWidth));
                }
                else
                {
                    Console.Write('|');
                    Console.SetCursorPosition(left + boxWidth - 1, top + i);
                    Console.Write('|');
                }
            }

            Console.SetCursorPosition(left + (boxWidth - title.Length) / 2, top);
            Console.Write(title);

            Console.ResetColor();

            for (int i = 0; i < options.Length; i++)
            {
                Console.SetCursorPosition(left + 3, top + 2 + i);
                if (i == selectedIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("> ");
                }
                else
                {
                    Console.Write("  ");
                }
                Console.Write(options[i]);
                Console.ResetColor();
            }
        }
        public static void DrawMessageBox(string message, ConsoleColor color)
        {
            int width = Console.WindowWidth;
            int padding = 4; // 메시지 좌우에 추가 여백
            int boxWidth = Math.Max(message.Length + 2 * padding, 40); // 최소 박스 너비 30 설정
            int left = (width - boxWidth) / 2;

            // 메시지를 가운데로 정렬하기 위해 좌우 여백 계산
            int space = boxWidth - message.Length - 2;
            int leftSpace = space / 2;
            int rightSpace = space - leftSpace;

            Console.ForegroundColor = color;
            Console.SetCursorPosition(left, 1);
            Console.WriteLine(new string('-', boxWidth));

            Console.SetCursorPosition(left, 2);
            Console.WriteLine($"{" ".PadLeft(leftSpace)}{message}{" ".PadRight(rightSpace)}");

            Console.SetCursorPosition(left, 3);
            Console.WriteLine(new string('-', boxWidth));
            Console.ResetColor();
        }
    }
}
