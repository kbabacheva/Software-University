import java.util.Scanner;


public class _3_Eclipse {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int num = input.nextInt();
		String empty = new String(new char[num-1]).replace("\0"," ");
		String asterix = new String(new char[2*(num-1)]).replace("\0","*");
		String dash = new String(new char[2*(num-1)]).replace("\0","/");
		String bridge = new String(new char[(num-1)]).replace("\0","-");
		//first line
		System.out.println(" " + asterix + " " + empty + " " + asterix + " ");
		//after f line
		for (int i = 0; i < (num-3)/2; i++) {
			System.out.println("*" + dash + "*" + empty + "*" + dash + "*");
		}
		//bridge
		System.out.println("*" + dash + "*" + bridge + "*" + dash + "*");
		//after bridge
		for (int i = 0; i < (num-3)/2; i++) {
			System.out.println("*" + dash + "*" + empty + "*" + dash + "*");
		}
		//last line
		System.out.println(" " + asterix + " " + empty + " " + asterix + " ");
	}
}
