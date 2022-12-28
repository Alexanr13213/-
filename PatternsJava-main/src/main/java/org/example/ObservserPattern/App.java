package org.example.ObservserPattern;

import java.util.Scanner;

public class App
{
    public static void main( String[] args )
    {
        var cameraObservable = new CameraObservable();

        new Observer("1", cameraObservable);
        new Observer("2", cameraObservable);

        var observerToDelete = new Observer("3", cameraObservable);
        cameraObservable.removeObserver(observerToDelete);


        int[][] cameraMatrix = new int[10][10];
        Scanner scanner = new Scanner(System.in);
        for (int i = 0; i < 10; i++)
            for (int j = 0; j < 10; j++)
                cameraMatrix[i][j] = scanner.nextInt();

        cameraObservable.setCameraMatrix(cameraMatrix);

    }
}
