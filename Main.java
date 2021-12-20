package com;

import com.Clockss.Clock;
import com.Clockss.Clockz;
import com.Clockss.TimeException;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        List<Clock> list = new ArrayList();
        Clock quartz;
        list.add(quartz("Quartz", 1000, 0, 0));

        quartz = new quartz("Quartz", 1000, 0, 0);
        Clock casio = new casio("Casio", 23000, 0, 0);
        Clock Omega = new Omega("Omega", 3500, 0, 0);
        Clock Tissot = new Tissot("Tissot", 2750, 0, 0);
        Clockz Rolex = new Rolex("Rolex", 15000, 0, 0, 0);
        Clockz Cartier = new Cartier("Cartier", 10000, 0, 0, 0);
        Clockz Orient = new Orient("Rolex", 1000, 0, 0, 0);
        Clockz Swatch = new Swatch("Rolex", 150000, 0, 0, 0);
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

                System.out.println("Часы Quartz");
                quartz.toString();
                System.out.println("1.Установите время");
                System.out.println("2.Переведите время вперед");

                int vybor2 = scanner.nextInt();

                switch (vybor2) {
                    case 1 -> {
                        try {
                            quartz.set_time();
                            quartz.check(time_hour, time_minute);
                        } catch (TimeException e) {
                            System.out.println(e.getMessage());
                        }

                    }
                    case 2 -> {
                        System.out.println("Сколько часов добавить?");
                        time_hour = scanner.nextInt();
                        System.out.println("Сколько минут добавить?");
                        time_minute = scanner.nextInt();
                        quartz.forward(time_hour, time_minute);

                    }
                }

            }
            case 2 -> {
                System.out.println("Часы Casio");
                casio.toString();
                System.out.println("1.Установите время");
                System.out.println("2.Переведите время вперед");
                int vybor2 = scanner.nextInt();
                switch (vybor2) {
                    case 1 -> {

                        try {
                            casio.set_time();
                            casio.check(time_hour, time_minute);
                        } catch (TimeException e) {
                            System.out.println(e.getMessage());
                        }


                    }
                    case 2 -> {
                        System.out.println("Сколько часов добавить?");
                        time_hour = scanner.nextInt();
                        System.out.println("Сколько минут добавить?");
                        time_minute = scanner.nextInt();
                        casio.forward(time_hour, time_minute);

                    }
                }

            }
            case 3 -> {
                System.out.println("Часы Omega");
                Omega.toString();
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
                Tissot.toString();
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

    private static Clock quartz(String quartz, int i, int i1, int i2) {
        return null;
    }
}


