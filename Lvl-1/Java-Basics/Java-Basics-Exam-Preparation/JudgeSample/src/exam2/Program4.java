package exam2;

import java.util.Scanner;

public class Program4 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
        int num = input.nextInt();
        
        char[] letters = {'A','B','C','E','H','K','M','P','T','X'};
        int count = 0;
        int charX = 0;
        int charY = 0;
        for (int i = 0; i <= 9; i++)
        {
            for (int j = 0; j <= 9; j++)
            {
                for (int k = 0; k <=9; k++)
                {
                    for (int a = 0; a <=9; a++)
                    {
                        for (char x : letters)
                        {
                            for (char y : letters)
                            {
                                switch (x)
                                {
                                    case'A': charX=10; break;
                                    case'B': charX=20; break;
                                    case'C': charX=30; break;
                                    case'E': charX=50; break;
                                    case'H': charX=80; break;
                                    case'K': charX=110; break;
                                    case'M': charX=130; break;
                                    case'P': charX=160; break;
                                    case'T': charX=200; break;
                                    case'X': charX=240; break;
                                   
                                }
                                switch (y)
                                {
                                    case'A': charY=10; break;
                                    case'B': charY=20; break;
                                    case'C': charY=30; break;
                                    case'E': charY=50; break;
                                    case'H': charY=80; break;
                                    case'K': charY=110; break;
                                    case'M': charY=130; break;
                                    case'P': charY=160; break;
                                    case'T': charY=200; break;
                                    case'X': charY=240; break;
                                   
                                }
                                boolean isMagic = (i==j&&j==k&&k==a)||(j==k&&k==a)||(i==j&&j==k)||(i==j&&k==a)||(i==k&&j==a)||(i==a&&j==k);
                                if ((num==(i+j+k+a+charX+charY+40))&&isMagic)
                                {
                                    count++;
                                }
                                charX = 0;
                                charY = 0;
                            }
                        }
                    }
                }
            }
        }
        System.out.println(count);
    }
}


