import java.util.Scanner;

class Clocks {
    static int time_hour;//кол-во часов
    static int time_minute;
    String marka;
    int cost;

    public Clocks(String marka, int cost, int time_hour, int time_minute) {
        this.time_hour = time_hour;
        this.time_minute = time_minute;
        this.marka = marka;
        this.cost = cost;
    }



    static void forward(int hour, int minute) {
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

    public static void set_time(int hour, int minute) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Введите текущее время(Часы): ");
        hour = scanner.nextInt();
        System.out.println("Введите текущее время(Минуты): ");
        minute = scanner.nextInt();
        if (hour < 24 && hour >= 0 && minute < 60 && minute >= 0) {
            time_hour = hour;
            time_minute = minute;
        } else System.out.printf("Ошибка!");
    }

    public static void forward() {
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

    void doCost() { System.out.println("Стоимость часов: " + cost);}

    void doMarka() {
        System.out.println("Марка часов: " + marka);
    }

    void doTime_hour() {
        System.out.println("Часы: " + time_hour);
    }

    void doTime_minute() {
        System.out.println("Минуты: " + time_minute + "\n");
    }
}

class quartz extends Clocks {
    public quartz(String marka, int cost, int time_hour, int time_minute) {
        super(marka, cost, time_hour, time_minute);
    }
}

class casio extends Clocks {
    public casio(String marka, int cost, int time_hour, int time_minute) {
        super(marka, cost, time_hour, time_minute);
    }
}

class Omega extends Clocks {
    public Omega(String marka, int cost, int time_hour, int time_minute) {
        super(marka, cost, time_hour, time_minute);}
}

class Tissot extends Clocks {
    public Tissot(String marka, int cost, int time_hour, int time_minute) {
        super(marka, cost, time_hour, time_minute);}}