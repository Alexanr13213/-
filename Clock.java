package com.Clockss;

import java.util.Scanner;

public class Clock {
    int time_hour;//кол-во часов
    int time_minute;
    String marka;
    int cost;

    public Clock(String marka, int cost, int time_hour, int time_minute) {
        this.time_hour = time_hour;
        this.time_minute = time_minute;
        this.marka = marka;
        this.cost = cost;
    }

    public Clock() {
    }

    public void forward(int hour, int minute) {
        if (time_minute + minute >= 60) {
            time_minute = (time_minute + minute) - 60;
            time_hour += 1;
        } else time_minute += minute;
        if (time_hour + hour >= 24) {
            while (time_hour + hour >= 24)
                hour = (time_hour + hour - 24);
            time_hour += hour;
        } else time_hour += hour;
        System.out.printf("%d:%d\n", time_hour, time_minute);
    }

    public void set_time() {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Введите текущее время(Часы): ");
        int hour = scanner.nextInt();
        System.out.println("Введите текущее время(Минуты): ");
        int minute = scanner.nextInt();
        time_hour = hour;
        time_minute = minute;
        System.out.printf("%d:%d\n", time_hour, time_minute);
    }

    @Override
    public String toString() {
        return "Clocks{" +
                "time_hour=" + time_hour +
                ", time_minute=" + time_minute +
                ", marka='" + marka + '\'' +
                ", cost=" + cost +
                '}';
    }

    public void check(int hour, int minute) throws TimeException {
        if (((time_hour > 24) || (time_hour < 0)) || ((time_minute > 60) || (time_minute < 0)))
            throw new TimeException("Exception: time is wrong!");
        else {
            System.out.println("Все за@бись!");
        }
    }

}
    class quartz extends Clock {
    public quartz(String marka, int cost, int time_hour, int time_minute) {
        super(marka, cost, time_hour, time_minute);
    }
}
    class casio extends Clock {
    public casio(String marka, int cost, int time_hour, int time_minute) {
        super(marka, cost, time_hour, time_minute);
    }
}
    class Omega extends Clock {
    public Omega(String marka, int cost, int time_hour, int time_minute) {
        super(marka, cost, time_hour, time_minute);
    }
}
    class Tissot extends Clock {
    public Tissot(String marka, int cost, int time_hour, int time_minute) {
        super(marka, cost, time_hour, time_minute);}

    }
