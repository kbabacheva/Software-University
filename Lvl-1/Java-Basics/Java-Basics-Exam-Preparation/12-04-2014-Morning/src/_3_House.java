
public class _3_House {

	public static void main(String[] args) {
		int num = 15;
		int m = 1;
		int n = num;
		
		//first line
		System.out.println(new String(new char[n/2]).replace("\0",".") + "*" + new String(new char[n/2]).replace("\0","."));
		//roof
		 m = 1;
		 n = (num-2*m)/2;
		for (int i = 0; i < (num-3)/2; i++) {
			String outterDots = new String(new char[n]).replace("\0",".");
			String innerDots = new String(new char[m]).replace("\0",".");
			System.out.println(outterDots + "*" + innerDots + "*" + outterDots);
			n--;
			m+=2;
		}
		//middle
		System.out.println(new String(new char[num]).replace("\0","*"));
		//house
		for (int i = 0; i < (num-3)/2; i++) {
			n = num/4;
			m = num - (2*n + 2);
			String outterDots = new String(new char[n]).replace("\0",".");
			String innerDots = new String(new char[m]).replace("\0",".");
			System.out.println(outterDots + "*" + innerDots + "*" + outterDots);
		}
		//end
		n = num/4;
		m = num - 2*n;
		String outterDots = new String(new char[n]).replace("\0",".");
		String asterix = new String(new char[m]).replace("\0","*");
		System.out.println(outterDots + asterix + outterDots);
	}
}
