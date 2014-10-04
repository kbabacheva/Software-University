import java.util.Scanner;


public class _3_NewHouse {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int num = input.nextInt();
		int n = num;
		int m = 1;
		//roof
		for (int i = 0; i < (num+1)/2; i++) {
			String asterix = new String(new char[m]).replace("\0","*");
			String dash = new String(new char[n/2]).replace("\0","-");
			System.out.println(dash + asterix + dash);
			n-=2;
			m +=2;
		}
		//house
		String house = new String(new char[num-2]).replace("\0","*");
		for (int i = 0; i < num; i++) {
			System.out.println("|" + house + "|");
		}
	}
}
