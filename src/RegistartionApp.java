import java.util.Scanner;

public class RegistartionApp {

	public static void main(String[] args) {
		System.out.println("Student Registration App");
		System.out.println();
		
		
		Scanner sc = new Scanner(System.in);
		
		System.out.print("Enter first name: ");
		String firstName = sc.next();
		System.out.print("Enter last name: ");
		String lastName = sc.next();
		System.out.print("Enter year of birth: ");
		int birthYear = sc.nextInt();
		System.out.println();
		
		
		System.out.println("Welcome " + firstName + " " + lastName + "!");
		System.out.println("Your registration is complete.");
		System.out.println("Your password is " + firstName + "*" + birthYear);
		
		
		
		
		sc.close();
		System.out.println("Bye");

	}

}
