import java.util.Scanner;


public class _3_TheExplorer {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int num = input.nextInt();
		int n = num;
		int m = 1;
		String outDash = new String(new char[n/2]).replace("\0","-");
		String inDash = new String(new char[m]).replace("\0","-");
		//first line
		System.out.println(outDash + "*" + outDash);
		//after first line
		for (int i = 0; i < (num-1)/2; i++) {
			outDash = new String(new char[(n-2)/2]).replace("\0","-");
			inDash = new String(new char[m]).replace("\0","-");
			System.out.println(outDash + "*" + inDash + "*" + outDash);
			n -= 2;
			m += 2;
		}
		//after middle
		n = 1;
		m -=4;
		for (int i = 0; i < (num-2)/2; i++) {
			outDash = new String(new char[n]).replace("\0","-");
			inDash = new String(new char[m]).replace("\0","-");
			System.out.println(outDash + "*" + inDash + "*" + outDash);
			n++;
			m-=2;
		}
		//last
		n = num/2;
		outDash = new String(new char[n]).replace("\0","-");
		System.out.println(outDash + "*" + outDash);
	}
}
