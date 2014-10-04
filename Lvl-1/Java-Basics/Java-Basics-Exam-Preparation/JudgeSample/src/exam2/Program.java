package exam2;

import java.math.BigInteger;
import java.util.Scanner;

public class Program {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		long n1 = input.nextLong();
		BigInteger first = BigInteger.valueOf(n1);
		long n2 = input.nextLong();
        BigInteger second = BigInteger.valueOf(n2);
        long n3 = input.nextLong();
        BigInteger third = BigInteger.valueOf(n3);
        int n = input.nextInt();
        BigInteger next = BigInteger.valueOf(0);
        if (n == 1)
        {
            System.out.println(n1);
        }
        if (n == 2)
        {
        	System.out.println(n2);
        }
        if (n == 3)
        {
        	System.out.println(n3);
        }
        if (n > 3)
        {
            for (int i = 4; i <= n; i++)
            {
            	next = next.add(first);
            	next = next.add(second);
            	next = next.add(third);
                first = BigInteger.valueOf(0);
                first = first.add(second);
                second = BigInteger.valueOf(0);
                second = second.add(third);
                third = BigInteger.valueOf(0);
                third = third.add(next);
                next = BigInteger.valueOf(0);
            }
            System.out.println(third);
        }

	}

}
