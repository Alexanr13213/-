import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Clocks quartz = new quartz("Quartz", 1000, 00, 00);
        Clocks casio = new casio("Casio", 23000, 00, 00);
        Clocks Omega = new Omega("Omega", 3500, 00, 00);
        Clocks Tissot = new Tissot("Tissot", 2750, 00, 00);

        Scanner scanner = new Scanner(System.in);

        System.out.println("Выберите часы о которых хотите узнать:");
        System.out.println("1.Quartz");
        System.out.println("2.Casio");
        System.out.println("3.Omega");
        System.out.println("4.Tissot");

        int vybor = scanner.nextInt();
        switch(vybor)
        {
            case 1: {
                System.out.println("Часы Quartz");
                quartz.doMarka();//Марка часов
                quartz.doCost();//Стоимость часов
                quartz.doTime_hour();//Часы
                quartz.doTime_minute();//Минуты
                System.out.println("1.Установите время");
                System.out.println("2.Переведите время вперед");

                int vybor2 = scanner.nextInt();

                switch(vybor2) {
                    case 1:{
                        Clocks.set_time(int hour, int minute);
                        break;
                    }
                    case 2:{
                        Clocks.forward();
                        break;
                    }
                    default:
                }

                }
                break;

        case 2: {
            System.out.println("Часы Casio");
            casio.doMarka();
            casio.doCost();
            casio.doTime_hour();
            casio.doTime_minute();
            int vybor2 = scanner.nextInt();
            switch(vybor2){
                case 1:{
                Clocks.set_time(int hour, int minute);
                    break;
                }
                case 2:{
                    Clocks.forward();
                    break;
                }
            }

        }
        break;
            case 3: {
                System.out.println("Часы Omega");
                Omega.doMarka();
                Omega.doCost();
                Omega.doTime_hour();
                Omega.doTime_minute();
                int vybor2 = scanner.nextInt();
                switch(vybor2){
                    case 1:{
                        Clocks.set_time(int hour, int minute);
                        break;
                    }
                    case 2:{
                        Clocks.forward();
                        break;
                    }
                }

            }
            break;
            case 4: {
                System.out.println("Часы Tissot");
                Tissot.doMarka();
                Tissot.doCost();
                Tissot.doTime_hour();
                Tissot.doTime_minute();
                int vybor2 = scanner.nextInt();
                switch(vybor2){
                    case 1:{
                        Clocks.set_time(int hour, int minute);
                    }
                    case 2:{
                        Clocks.forward();
                        break;
                    }
                }

            }
            break;
    }
        };
    }


