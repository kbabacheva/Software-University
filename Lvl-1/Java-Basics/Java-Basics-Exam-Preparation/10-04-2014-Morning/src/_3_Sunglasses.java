import java.util.Scanner;


public class _3_Sunglasses {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int n = input.nextInt();
		String empty = new String(new char[n]);
		String asterix = new String(new char[2*n]).replace("\0","*");
		String dash = new String(new char[2*(n-1)]).replace("\0","/");
		String bridge = empty.replace("\0","|");
		
		//First line
		System.out.println(asterix+empty+asterix);
		//After 1st line
		for (int i = 0; i < (n-3)/2; i++) {
			System.out.println("*" + dash + "*" + empty + "*" + dash + "*");
		}
		//Bridge
		System.out.println("*" + dash + "*" + bridge + "*" + dash + "*");
		//After bridge
		for (int i = 0; i < (n-3)/2; i++) {
			System.out.println("*" + dash + "*" + empty + "*" + dash + "*");
		}
		//Last line
		System.out.println(asterix+empty+asterix);
	}
}
