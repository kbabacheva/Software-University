package exam2;

import java.util.Scanner;

public class Program3 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int num = input.nextInt();
		int n = num;
		int m = 0;
		for (int i = 0; i < num/2 + 1; i++) {
			String asterix = new String(new char[n]).replace("\0","*");
			String dot = new String(new char[m]).replace("\0",".");
			System.out.println(dot+asterix+dot);
			n-=2;
			m++;
		}
		n = 3;
		m = (num-n)/2;
		for (int i = 0; i < num/2; i++) {
			String asterix = new String(new char[n]).replace("\0","*");
			String dot = new String(new char[m]).replace("\0",".");
			System.out.println(dot+asterix+dot);
			n+=2;
			m--;
		}
	}

}
