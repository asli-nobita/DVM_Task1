/* Smartphones (portrait) ----------- */
@media only screen 
and (max-width : 320px) {
    .small {
        position: fixed;
        top: 0;
        height: auto;
        width: 100%;
        overflow: hidden;
        background-color: black;
        color: var(--text-color);
        display: flex;
        flex-direction: row;
        justify-content: space-between;
        align-items: center;
        padding: 0 200px;
        border-bottom: 1.5px solid var(--primary-color);
    }
    .large {
        display: none;
    }
    #nav-options {
        display: flex;
        flex-direction: row;
        justify-content: space-between;
    }
    #nav-options a {
        color: var(--text-color);
    }
    #nav-options li {
        margin: 5px 35px;
    }
    #hamburger-menu {
        cursor: pointer;
    }
    
    h1 {
        font-size: 3.2rem;
        padding: 0;
        margin: 0;
    }
    h3 {
        font-size: 1.5rem;
        font-weight: 400;
    }
    .section-large {
        height: 1036.8px;
    }
    .heading {
        text-align: center;
    }
    #RING {
        margin-top: 150px;
        background-image: url(assets/holiday-gift-guide-2023-homepage-large-2x.jpg);
        background-repeat: no-repeat;
        background-size: 100%;
    }
    .links {
        font-size: 1.2rem;
    }
    
    .card {
        height: 580px;
        margin: 10px;
    }
    #FUJIN {
        background-image: url(https://assets2.razerzone.com/images/pnx.assets/65d476e8aff78d448b6b3233350f1bb0/fujin-pro-b-950x580-desktop.webp);
    }
    #BLADE18 {
        background-image: url(https://assets2.razerzone.com/images/pnx.assets/2fb5601db7a84213129e2f26d31f050f/mercury-blade16-blade18-b-950x580-desktop.webp);
    }
    #BLADE14 {
        background-image: url(https://assets2.razerzone.com/images/pnx.assets/ab20c0e7b6887e4438c7bb329c59b288/razer-blade-14-2023-b-950x580-desktop.webp);
    }
    #HYPERPOLLING {
        background-image: url(https://assets2.razerzone.com/images/pnx.assets/bbffede42365ea3ed65d0b13ab080c48/razer-hyperpolling-technology-b-950x580-desktop.webp);
    }
    #AHSOKA {
        background-image: url(https://assets2.razerzone.com/images/pnx.assets/65d476e8aff78d448b6b3233350f1bb0/axon-ashoka-950x580-desktop.webp);
    }
    #GIFT-CARD {
        background-image: url(https://assets2.razerzone.com/images/pnx.assets/65d476e8aff78d448b6b3233350f1bb0/ebonus-card-b-950x580-desktop.webp);
    }
    footer {
        font-size: 0.75rem;
        color: var(--text-color);
        background-color: black;
        padding: 25px;
    }
    .footer-flex {
        display: flex;
        flex-direction: row;
        justify-content: space-between;
        align-items: flex-start;
        padding: 25px 50px;
    }
    .footer-grid {
        display: grid;
        grid-template-columns: repeat(5, 1fr);
        max-width: 60%;
        margin: 0;
        padding: 0;
    }
    .footer-list {
        padding: 0;
        margin: 0;
    }
    .footer-list-heading {
        color: white;
    }
    .footer-list li {
        margin: 10px;
    }
    .footer-list a {
        color: var(--text-color);
    }
    #footer-text {
        color: var(--text-color);
        display: flex;
        flex-direction: row;
        justify-content: space-between;
    }
    #copyright {
        display: flex;
        flex-direction: row;
        justify-content: space-between;
        margin-left: 50px;
    }
    #copyright ul {
        margin: 10px;
        padding: 0;
        display: flex;
        flex-direction: row;
        justify-content: space-between;
    }
    #location {
        margin-right: 50px;
    }
    #footer-text ul {
        display: flex;
        flex-direction: row;
        justify-content: space-between;
    }
    #green-text {
        color: var(--primary-color);
    }
}
