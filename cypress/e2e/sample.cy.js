describe('User Input Test', () => {
    it('Allows user to enter name and displays greeting', () => {
        cy.visit('http://localhost:3000');
        cy.get('#nameInput').type('Alice');
        cy.get('#submitButton').click();
        cy.contains('Hello, Alice!');
    });
});