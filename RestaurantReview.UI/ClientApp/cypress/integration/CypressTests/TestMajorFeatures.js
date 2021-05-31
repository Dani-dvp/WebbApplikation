/// <reference types="Cypress"/>


const restaurant = 'Fiskekrogen'
const title = 'This is a title'
const maintext = 'This is the main text'
const rating = '5'
const editedtext = 'This is a edited text'

describe('Test all major features', () => {

    
    describe('Logged in functions', () => {
        before(() => {
            cy.register()
            cy.login()
        })


         it('Create a restaurant', () => {

            cy.visit('/')

             cy.get('[data-cy=navbarReview').click()

             cy.location('pathname').should('equal', '/createreview')

             cy.get('[data-cy=addRestaurant').click()

             cy.get('[data-cy=restaurantName').type(restaurant)

             cy.get('[data-cy=restaurantDescription').type(maintext)

             cy.get('[data-cy=submitRestaurant').click()
         });


        //  it('Create a review', () => {

        //     cy.visit('/')

        //      cy.get('[data-cy=navbarReview').click()

        //      cy.location('pathname').should('equal', '/createreview')

        //      cy.get('[data-cy=reviewRestaurantName').type(restaurant)

        //      cy.get('[data-cy=reviewText').type(maintext)

        //      //cy.get('[data-cy=fivestar').click()

        //      cy.get('[data-cy=submitReview').click()

    
        //  });

        // it('Edit a review', () => {

        //     cy.get('[data-cy=profile').click()
    
        //     cy.get('[data-cy=editreview').click()

        //     cy.get('[data-cy=review').type(editedtext)

        //     cy.get('[data-cy=threestar').click()

        //     cy.get('[data-cy=submitreview').click()
    
        // });


        
    })

    








})