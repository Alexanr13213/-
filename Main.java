package com;

import com.Clockss.*;
import com.Clockss.TimeException;

import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.Set;
import java.util.TreeSet;

public class Main {
    public void main(String[] args) {
        List<Clock> showCase = Arrays.asList(
        new Quartz("Quartz", 1000, 0, 0),
        new Casio("Casio", 23000, 0, 0),
        new Omega("Omega", 3500, 0, 0),
        new Tissot("Tissot", 2750, 0, 0));

        List<Clockz> showCase1 = Arrays.asList(
        new Rolex("Rolex", 15000, 0, 0, 0),
        new Cartier("Cartier", 10000, 0, 0, 0),
        new Orient("Rolex", 1000, 0, 0, 0),
        new Swatch("Rolex", 150000, 0, 0, 0));

        Scanner scanner = new Scanner(System.in);


        System.out.println("Выберите часы о которых хотите узнать:");
        System.out.println("1.Quartz");
        System.out.println("2.Casio");
        System.out.println("3.Omega");
        System.out.println("4.Tissot");

        int vybor = scanner.nextInt();
        int time_hour = 0;
        int time_minute = 0;
        switch (vybor) {
            case 1 -> {

                System.out.println("Часы Quartz\n");
                Quartz.String();
                System.out.println("1.Установите время\n");
                System.out.println("2.Переведите время вперед\n");

                int vybor2 = scanner.nextInt();

                switch (vybor2) {
                    case 1 -> {
                        try {
                            Quartz.set_time();
                            Quartz.check(time_hour, time_minute);
                        } catch (TimeException e) {
                            System.out.println(e.getMessage());
                        }

                    }
                    case 2 -> {
                        System.out.println("Сколько часов добавить?");
                        time_hour = scanner.nextInt();
                        System.out.println("Сколько минут добавить?");
                        time_minute = scanner.nextInt();
                        Quartz.forward(time_hour, time_minute);

                    }
                }

            }
            case 2 -> {
                System.out.println("Часы Casio");
                Casio.String();
                System.out.println("1.Установите время");
                System.out.println("2.Переведите время вперед");
                int vybor2 = scanner.nextInt();
                switch (vybor2) {
                    case 1 -> {

                        try {
                            Casio.set_time();
                            Casio.check(time_hour, time_minute);
                        } catch (TimeException e) {
                            System.out.println(e.getMessage());
                        }


                    }
                    case 2 -> {
                        System.out.println("Сколько часов добавить?");
                        time_hour = scanner.nextInt();
                        System.out.println("Сколько минут добавить?");
                        time_minute = scanner.nextInt();
                        Casio.forward(time_hour, time_minute);

                    }
                }

            }
            case 3 -> {
                System.out.println("Часы Omega");
                Omega.String();
                System.out.println("1.Установите время");
                System.out.println("2.Переведите время вперед");
                int vybor2 = scanner.nextInt();
                switch (vybor2) {
                    case 1 -> {

                        try {
                            Omega.set_time();
                            Omega.check(time_hour, time_minute);
                        } catch (TimeException e) {
                            System.out.println(e.getMessage());
                        }

                    }
                    case 2 -> {
                        System.out.println("Сколько часов добавить?");
                        time_hour = scanner.nextInt();
                        System.out.println("Сколько минут добавить?");
                        time_minute = scanner.nextInt();
                        Omega.forward(time_hour, time_minute);

                    }
                }

            }
            case 4 -> {
                System.out.println("Часы Tissot");
                Tissot.String();
                System.out.println("1.Установите время");
                System.out.println("2.Переведите время вперед");
                int vybor2 = scanner.nextInt();
                switch (vybor2) {
                    case 1 -> {

                        try {
                            Tissot.set_time();
                            Tissot.check(time_hour, time_minute);
                        } catch (TimeException e) {
                            System.out.println(e.getMessage());
                        }
                    }
                    case 2 -> {
                        System.out.println("Сколько часов добавить?");
                        time_hour = scanner.nextInt();
                        System.out.println("Сколько минут добавить?");
                        time_minute = scanner.nextInt();
                        Tissot.forward(time_hour, time_minute);
                    }
                }

            }
        }
    }
}


