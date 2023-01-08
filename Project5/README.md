#Paper Trading Web Application
ASP .Net web application. Users create accounts and can purchase stocks and crypto. They can also view their portfolios.

#List of Services
![pic1](https://github.com/benwallace5/CSE412Project/blob/main/COVID-19%20Database%20Photos/Picture1.png)

# CreditCardRESTfulService
verifyCard(string cardNo)  implements Luhn Algorithm to verify credit card no: cardNo(string) output: 0 if cardNo is valid, -1 if invalid

#LoginService
int signUp(string username, string password);
searches MemberCredentials.xml for User with matching username, creates new user if one does not exist
Input: string username, string password
Output:
0 = success
-1 = username already exists

int signIn(string username, string password); 
searches MemberCredentials.xml for User with matching username and password. Input: string username, string password Ouput: 0=found, -1=not found

