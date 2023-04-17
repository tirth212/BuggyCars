# BuggyCars

Test Approach

-	Functional Testing
-	Compatibility Testing – device and browser
-	Security Testing

Bugs –
Title: Overall Rating Page - All links are broken on Stratos Lancia Page, page does not have data to show up
Sev: High
Priority: High
Steps:
1.	Go to list of all registered models.
2.	Navigate to page 4 to find Lancia Stratos
3.	Select Stratos
4.	Click on Buggy Rating or Enter valid credentials for login.
5.	Observe
Actual outcome: User is not able redirect to other pages; all links are broken.
Expected outcome: User should be able to navigate all pages, links should work fine.

Title: Overall Rating Page - Registered Car Image is broken
Sev: Low
Priority: High
Steps:
1.	Go to list of all registered models.
2.	Navigate to page 4 to find Lancia Ypsilon -> Observe.
3.	Select Ypsilon
4.	Observe
Actual outcome: Image is broken.
Expected outcome: Image should not be broken.

Title: Popular Model page – Clicking on Buggy Rating does not redirect to Home Page
Sev: Low
Priority: Med
URL: https://buggy.justtestit.org/
Repro Steps: 
1.	Select Popular Model
2.	Click on Buggy Rating 
3.	Observe
Actual output: Website do not redirect to home page
Expected Output: User should be able to go back to home page.

Title: Popular Model page – User is not able to sort by Model and Rank
Sev: Low
Priority: Low
URL: https://buggy.justtestit.org/
Repro Steps: 
1.	Select Popular Model
2.	Try to sort by Model and Rank
3.	Observe
Actual output: User is not able to sort by Model and Rank
Expected Output: User should be sort by Model and Rank.

Title: Overall Rating Page – Invalid Page number manually entered
Sev: Med
Priority: High
Steps:
1.	Go to list of all registered models.
2.	Go bottom of the page where ‘page 1 of 5’ displayed
3.	Search with Invalid page number into the box and click on enter
4.	Observe
Actual outcome: Invalid page number redirects to blank page
Expected outcome: Invalid page number should show inline error.
