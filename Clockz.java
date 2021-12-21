package com.Clockss;

import java.util.Scanner;

public class Clockz extends Clock {
    int time_hour;//кол-во часов
    int time_minute;
    int time_second;
    String marka;
    int cost;

    public Clockz(String marka, int cost, int time_hour, int time_minute, int time_second) {
        this.time_hour = time_hour;
        this.time_minute = time_minute;
        this.time_second = time_second;
        this.marka = marka;
        this.cost = cost;
    }

    void forward(int hour, int minute, int second) {
        if (time_minute + minute >= 60) {
            time_minute = (time_minute + minute) - 60;
            time_hour += 1;
        } else time_minute += minute;
        if (time_hour + hour >= 24) {
            while (time_hour + hour >= 24)
                hour = (time_hour + hour - 24);
            time_hour += hour;
        } else time_hour += hour;
        if (time_second + second >= 60) {
            time_second = (time_second + second) - 60;
            time_minute += 1;
        } else time_second += second;

        System.out.printf("%d:%d:%d\n", time_hour, time_minute, time_second);
    }

    public void set_time() {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Введите текущее время(Часы): ");
        int hour = scanner.nextInt();
        System.out.println("Введите текущее время(Минуты): ");
        int minute = scanner.nextInt();
        System.out.println("Введите текущее время(Секунды): ");
        int second = scanner.nextInt();
        time_hour = hour;
        time_minute = minute;
        time_second = second;
        System.out.printf("%d:%d:%d\n", time_hour, time_minute, time_second);
    }


    public void String () {
        System.out.printf("%dУстановленное время(часы)", time_hour);
        System.out.printf("%dУстановленное время(минуты)", time_minute);
        System.out.printf("%dУстановленное время(минуты)", time_second);
        System.out.printf("%sМарка часов",marka);
        System.out.printf("%dСтоимость часов",cost);
    }

    public void check(int hour, int minute) throws TimeException {
        if (((time_hour > 24) || (time_hour < 0)) || ((time_minute > 60) || (time_minute < 0)) || ((time_second > 60) || (time_second < 0)))
            throw new TimeException("Exception: time is wrong!");
        else {
            System.out.println("Все за@бись!");
        }
    }

}


