@charset "UTF-8";
/* http://meyerweb.com/eric/tools/css/reset/ 
   v2.0 | 20110126
   License: none (public domain)
*/
html, body, div, span, applet, object, iframe,
h1, h2, h3, h4, h5, h6, p, blockquote, pre,
a, abbr, acronym, address, big, cite, code,
del, dfn, em, img, ins, kbd, q, s, samp,
small, strike, strong, sub, sup, tt, var,
b, u, i, center,
dl, dt, dd, ol, ul, li,
fieldset, form, label, legend,
table, caption, tbody, tfoot, thead, tr, th, td,
article, aside, canvas, details, embed,
figure, figcaption, footer, header, hgroup,
menu, nav, output, ruby, section, summary,
time, mark, audio, video {
  margin: 0;
  padding: 0;
  border: 0;
  font-size: 100%;
  font: inherit;
  vertical-align: baseline;
}

/* HTML5 display-role reset for older browsers */
article, aside, details, figcaption, figure,
footer, header, hgroup, menu, nav, section {
  display: block;
}

body {
  line-height: 1;
}

ol, ul {
  list-style: none;
}

blockquote, q {
  quotes: none;
}

blockquote:before, blockquote:after,
q:before, q:after {
  content: "";
  content: none;
}

table {
  border-collapse: collapse;
  border-spacing: 0;
}

h1 {
  font-size: 3.5rem;
  line-height: 1.5;
}

h2 {
  font-size: 2.3125rem;
  line-height: 1.5945945946;
}

h3 {
  font-size: 1.8rem;
  line-height: 1.5;
}

h4 {
  font-size: 1.4375rem;
  line-height: 1.6956521739;
}

h5 {
  font-size: 1.125rem;
  line-height: 1.7777777778;
}

h6 {
  font-size: 0.875rem;
  line-height: 1.8571428571;
}

.tweetgroup, .pricing-cards, .course-content .module-container .module-details, .features, .nav-ul, .nav {
  display: -webkit-box;
  display: -ms-flexbox;
  display: flex;
  -webkit-box-pack: justify;
  -ms-flex-pack: justify;
  justify-content: space-between;
  -webkit-box-align: center;
  -ms-flex-align: center;
  align-items: center;
}

.social-flex, .footer-flex, .pro-pricing-feature, .offer-price, .price, .pro-pricing-intro {
  display: -webkit-box;
  display: -ms-flexbox;
  display: flex;
  justify-content: flex-start;
  -webkit-box-align: center;
  -ms-flex-align: center;
  align-items: center;
}

.testimonial, .content-wrapper, .carousel__photo, .author, .testimonial-head, .more-testimonial-head, .pricing-plan, .pricing-info-head, .premium-btn, .pricing-head, .course-highlights, .course-article, .course-details-heading, .key-features-heading, .hero-features, .hero {
  display: -webkit-box;
  display: -ms-flexbox;
  display: flex;
  -webkit-box-pack: center;
  -ms-flex-pack: center;
  justify-content: center;
  -webkit-box-align: center;
  -ms-flex-align: center;
  align-items: center;
}

@media screen and (max-width: 768px) {
  .tweetgroup, .pricing-cards, .course-content .module-container .module-details, .features, .nav-ul, .nav {
    flex-wrap: wrap;
  }

  .social-flex, .footer-flex, .pro-pricing-feature, .offer-price, .price, .pro-pricing-intro {
    flex-wrap: wrap;
  }

  .testimonial, .content-wrapper, .carousel__photo, .author, .testimonial-head, .more-testimonial-head, .pricing-plan, .pricing-info-head, .premium-btn, .pricing-head, .course-highlights, .course-article, .course-details-heading, .key-features-heading, .hero-features, .hero {
    flex-wrap: wrap;
  }
}
html {
  font-size: 16px;
}

*,
*::before,
*::after {
  box-sizing: border-box;
}

body {
  font-family: "Source Sans Pro";
  line-height: 1.5;
  text-rendering: optimizeLegibility;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
}

.container {
  max-width: 1140px;
  margin: 0 auto;
  padding: 0 1.5rem;
}

h4 {
  letter-spacing: -0.05rem;
}

h5 {
  letter-spacing: 0;
}

h6 {
  letter-spacing: 0;
}

button {
  outline: 0;
  border: none;
}

.btn {
  margin-top: 1.5rem;
  padding: 0.75rem 6rem;
  font-size: 1.1rem;
  letter-spacing: 0.06rem;
  border-radius: 3px;
  cursor: pointer;
  background: #3ecf8e;
  text-decoration: none;
  text-transform: uppercase;
  color: white;
  display: inline-block;
  font-family: "Mukta", sans-serif;
  font-weight: 600;
  box-shadow: 0 4px 6px rgba(50, 50, 93, 0.11), 0 1px 3px rgba(0, 0, 0, 0.08);
}
.btn:hover {
  color: #e6e1e1;
  transform: translateY(-1px);
  transition: all 0.3s ease;
  box-shadow: 4px 4px 8px rgba(0, 0, 0, 0.3);
}

.padding {
  padding: 5rem 0;
}

.img-responsive {
  width: 100%;
  height: auto;
}

.col-1-2 {
  flex: 1 1 40%;
}

.col-img {
  flex: 1 1 60%;
}

.padding-left {
  padding-left: 3rem;
}

.flex-between {
  display: flex;
  align-items: center;
  justify-content: space-between;
  flex-wrap: wrap;
}

.item-start {
  align-items: flex-start;
}

@media screen and (max-width: 768px) {
  html {
    font-size: 12px;
  }

  .wrap {
    flex-wrap: wrap;
  }

  .padding-left {
    padding-left: 0;
  }

  .col-1-2 {
    flex: 1 1 100%;
    order: 1;
    padding: 3rem 2rem 0 2rem;
  }

  .col-img {
    flex: 1 1 100%;
  }
}
.bg-1 {
  background: #e6ebf1;
}
.bg-1 h3 {
  color: #008168;
  font-size: 1.8rem;
  font-family: "Lato", sans-serif;
}
.bg-1 h6 {
  font-size: 1.4rem;
  font-family: "Mukta", sans-serif;
}
.bg-1 p {
  font-size: 1.1rem;
  line-height: 1.7;
}

.feature-description {
  margin-top: 1rem;
}

.bg-2 {
  background: #f6f9fc;
}
.bg-2 h3 {
  color: textBg1Heading;
  font-family: "Lato", sans-serif;
}
.bg-2 h6 {
  font-size: 1.3rem;
  font-family: "Mukta", sans-serif;
}

.header {
  background-color: #f6f9fc;
  border-bottom: 2px solid #e9f4f4;
}
.header .active {
  border-bottom: 2px solid #3ecf8e;
}

.logo {
  font-size: 0;
}

.nav-item .btn {
  font-size: 1rem;
  padding: 0.2rem 0.8rem;
  background: #32325d;
  margin-top: 0;
  color: #f1f0f0;
  color: white;
  border: 0.5px solid #32325d;
}
.nav-item .login-header {
  background: none;
  color: #6b7c93;
}
.nav-item .signup-header {
  margin-left: 0.8rem;
}

.logo-img {
  width: 75%;
}

.nav.container {
  padding: 0.7rem 1.5rem;
}

.nav-link {
  margin-left: 2.5rem;
  color: #6b7c93;
  text-decoration: none;
  font-size: 1.3rem;
}

.bars img {
  width: 30px;
}

.close-menu img {
  width: 25px;
}

.bars, .toggle, .close-menu {
  display: none;
}

@media screen and (max-width: 768px) {
  .nav-menu {
    padding-top: 2rem;
    display: none;
    position: fixed;
    z-index: 5;
    left: 0;
    top: 0;
    right: 0;
    bottom: -120%;
    text-align: center;
    padding-top: 80px;
    background: #32325d;
  }
  .nav-menu a {
    display: inline-block;
    color: #fcd668;
    font-size: 2.5rem;
    margin: 1rem 0;
  }

  .nav-ul {
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: center;
  }

  .bars, .close-menu {
    display: inline-block;
  }

  .logo {
    display: inline-block;
    z-index: 3;
    position: relative;
  }

  .toggle:checked ~ .nav-menu {
    display: inline-block;
  }

  .nav-link:hover {
    color: #3ecf8e;
  }

  .close-menu {
    position: absolute;
    right: 0;
    left: 83%;
    top: 1.2%;
  }

  .nav-item .btn {
    background: #3ecf8e;
    padding: 0.4rem 2.5rem;
    font-size: 1.25rem;
    color: white;
    font-weight: 400;
    border-radius: 3px;
    border: 0;
    box-shadow: none;
  }
  .nav-item .login-header {
    margin: 1.5rem 0;
    width: 5rem;
  }
  .nav-item .signup-header {
    margin-left: 0;
    width: 5rem;
  }
}
.hero {
  background-color: #f6f9fc;
  margin: 0 auto;
  text-align: center;
}

.hero-main {
  text-align: center;
  margin: 8rem 0 6rem;
}
.hero-main h1 {
  width: 69%;
  font-weight: 700;
  font-family: "Lato", sans-serif;
  margin: 0 auto;
  line-height: 1.2;
  color: #32325d;
}
.hero-main h3 {
  color: #35322d;
  font-size: 1.6rem;
  font-weight: 300;
  line-height: 1.4;
  margin: 2rem auto 1.7rem;
  font-family: "Source Sans Pro", sans-serif;
  color: #424770;
}
.hero-main .btn {
  margin-top: 3.5rem;
}

.hero-features h5 {
  margin-left: 1rem;
  line-height: 0.9;
  color: #32325d;
  border-bottom: 4px solid #fcd668;
}
.hero-features h5:first-child {
  margin-left: 0;
  border-left: 0;
  padding-left: 0;
}
.hero-features .group-logo1 {
  width: 20%;
  margin-right: 7rem;
  position: absolute;
  left: 0%;
  bottom: 30%;
  z-index: 1;
}
.hero-features .group-logo2 {
  width: 20%;
  margin-left: 7rem;
  position: absolute;
  right: 0%;
  bottom: 30%;
  z-index: 1;
}

@media screen and (max-width: 768px) {
  .hero-main {
    margin: 4rem 0;
  }
  .hero-main h1 {
    width: 100%;
    font-size: 3.1rem;
  }
  .hero-main h3 {
    font-size: 1.5rem;
  }
}
.key-features {
  background: #e6ebf1;
}

.key-head {
  background: #e6ebf1;
  left: 0%;
  width: 100%;
}

.key-features-heading {
  width: 100%;
}
.key-features-heading h2 {
  font-family: "Lato", sans-serif;
  font-weight: 700;
  font-size: 2.8rem;
  color: #32325d;
}
.key-features-heading img {
  display: inline-block;
  width: 3rem;
  margin-right: 1rem;
}

.features {
  width: 100%;
  z-index: 1;
  padding-top: 3rem;
}

.key-features-cards {
  margin: 0 1.5rem;
  padding: 1.75rem;
  text-align: center;
  align-self: stretch;
  background-color: #fcfcfc;
  box-shadow: 4px 4px 10px rgba(0, 0, 0, 0.5);
  border-radius: 10px;
}
.key-features-cards:first-child {
  margin-left: 0;
}
.key-features-cards:last-child {
  margin-right: 0;
}
.key-features-cards:hover {
  transform: translateY(-2px);
  transition: all 0.3s ease;
  box-shadow: 0 30px 60px -12px rgba(50, 50, 90, 0.25), 0 18px 36px -18px rgba(0, 0, 0, 0.3), 0 -12px 36px -8px rgba(0, 0, 0, 0.025);
}
.key-features-cards h4 {
  text-align: left;
  color: #32325d;
  text-transform: uppercase;
  font-family: "Mukta", sans-serif;
  font-size: 1.2rem;
  letter-spacing: 0.45px;
  font-weight: 600;
  margin: 0.8rem 0;
}
.key-features-cards img {
  width: 25%;
}
.key-features-cards p {
  color: #3f3f3f;
}

.key-features-points {
  text-align: left;
}
.key-features-points .point-item {
  display: flex;
  align-items: center;
  margin: 0.75rem 0rem;
}
.key-features-points .point-item:first-child {
  margin-top: 0.45rem;
}
.key-features-points .point-icon {
  width: 7%;
}
.key-features-points .point-item-title {
  margin-left: 0.25rem;
  font-size: 1rem;
  margin-top: -0.3rem;
}

@media screen and (max-width: 768px) {
  .features {
    flex-direction: column;
    align-items: center;
    justify-content: center;
  }

  .key-features {
    position: static;
  }

  .key-head {
    position: static;
  }

  .features {
    position: static;
  }

  .key-features-heading {
    flex-direction: column;
    text-align: center;
  }
  .key-features-heading h2 {
    font-size: 2.4rem;
  }
  .key-features-heading img {
    margin-right: none;
    width: 50px;
  }

  .key-features-cards {
    margin: 0;
    margin-top: 4rem;
    align-self: auto;
  }
  .key-features-cards:first-child {
    margin-top: 0;
  }
  .key-features-cards:hover {
    transform: none;
    transition: none;
    box-shadow: 4px 4px 10px rgba(0, 0, 0, 0.5);
  }

  .point-item .point-item-title {
    font-size: 1.1rem;
  }
}
@media screen and (max-width: 1024px) {
  .key-features-cards:hover {
    transform: none;
    transition: none;
    box-shadow: 4px 4px 10px rgba(0, 0, 0, 0.5);
  }
}
.course-shadow {
  box-shadow: 0 13px 27px -5px rgba(50, 50, 93, 0.25), 0 8px 16px -8px rgba(0, 0, 0, 0.3), 0 -6px 16px -6px rgba(0, 0, 0, 0.025);
  border-top-left-radius: 20px;
  border-top-right-radius: 20px;
  border-bottom-left-radius: 20px;
  border-bottom-right-radius: 20px;
  margin-bottom: 3rem;
}

.course-details {
  background: #f6f9fc;
}

.course-details-heading {
  text-align: center;
  font-family: "Lato", sans-serif;
}
.course-details-heading h2 {
  font-size: 2.8rem;
  font-weight: 700;
  color: #32325d;
}
.course-details-heading img {
  display: inline-block;
  width: 3rem;
  margin-right: 1rem;
}

.course-details-odd-row {
  background: #FBF5EF;
}

.course-details-even-row {
  background: #FFFAF5;
}

.course-article {
  padding: 2rem 0;
  cursor: arrow;
}
.course-article p {
  margin-bottom: 0.5rem;
  letter-spacing: 0.03rem;
}
.course-article:last-child {
  border-bottom-left-radius: 20px;
  border-bottom-right-radius: 20px;
}

.course-content-head {
  border-top-left-radius: 20px;
  border-top-right-radius: 20px;
  font-size: 2rem;
  font-weight: 800;
  background: #ece8e1;
  padding: 1rem 0;
}
.course-content-head p {
  font-size: 2rem;
}

.course-highlights {
  padding: 4rem 0;
  margin: 4rem 0;
  background: white;
}

.col {
  width: 25%;
  text-align: center;
  border-right: 1px solid #ededed;
}
.col:last-child {
  border-right: none;
}
.col .numbers {
  font-size: 4rem;
  font-weight: 700;
  font-family: "Mukta", sans-serif;
  margin-bottom: -1rem;
  color: #3ecf8e;
}
.col .topics {
  font-size: 1.4rem;
  font-weight: 600;
  font-family: "Mukta", sans-serif;
  text-transform: uppercase;
  color: #21396a;
}

.course-content .module-container {
  padding: 2rem;
}
.course-content .module-container h3 {
  color: #6672e5;
  color: #32325d;
  color: #008168;
  font-weight: 700;
  font-family: "Lato", sans-serif;
  text-transform: uppercase;
}
.course-content .module-container .module-details {
  align-items: flex-start;
  padding: 1rem 0;
}
.course-content .module-container .module-details h5 {
  color: #32325d;
  background: #fcd668;
  color: #896015;
  border-radius: 2px;
  padding: 0.1rem 0.6rem;
  display: inline-block;
  font-family: "Mukta", sans-serif;
  font-size: 1rem;
  margin-bottom: 0.8rem;
  background: #e9d495;
  color: #9d4210;
}
.course-content .module-container .module-details p {
  margin-bottom: 0.5rem;
  font-size: 1.1rem;
  color: #424770;
}
.course-content .module-container .module-details .module-topics {
  width: 70%;
}
.course-content .module-container .module-details .module-projects {
  width: 30%;
}
.course-content .module-container:nth-child(2n) {
  background: #e6ebf1cc;
}
.course-content .module-container:nth-child(2n) h3 {
  color: #32325d;
}
.course-content .module-container:nth-child(2n) h5 {
  background: #d7ecff;
  color: #494bae;
}
.course-content .module-container:nth-child(2n+1) {
  background: #e6ebf1;
}
.course-content .module-container:nth-child(2n+1) p {
  color: #525f7f;
}

@media screen and (max-width: 768px) {
  .course-highlights {
    flex-direction: column;
    margin: 2rem 0;
    padding: 1rem 0;
  }

  .col {
    width: 100%;
    padding: 1rem 0;
    border-bottom: 0.5px solid #ededed;
  }
  .col:last-child {
    border-bottom: 0;
  }

  .course-content .module-container .module-details .module-topics {
    width: 100%;
  }
  .course-content .module-container .module-details .module-projects {
    width: 100%;
  }

  .course-details-heading {
    flex-direction: column;
  }
  .course-details-heading h2 {
    font-size: 2.4rem;
  }
  .course-details-heading img {
    width: 50px;
  }
}
.flex {
  display: flex;
  flex-wrap: wrap;
  flex-direction: column;
  align-items: center;
  justify-content: center;
}
.flex .price-tag-btn {
  padding: 0.1rem 1rem;
}

.pricing {
  background: #f6f9fc;
}

.pricing-cards {
  justify-content: space-evenly;
  align-items: flex-start;
}

.pricing-head {
  margin-bottom: 3rem;
}
.pricing-head h2 {
  font-family: "Lato", sans-serif;
  font-weight: 700;
  font-size: 2.8rem;
  color: #32325d;
}
.pricing-head img {
  width: 3rem;
  display: inline-block;
  margin-right: 1rem;
}

.pro-pricing {
  border-radius: 8px;
  background: #ffff;
  box-shadow: 4px 4px 10px rgba(0, 0, 0, 0.5);
}
.pro-pricing:hover {
  transform: translateY(-1px);
  transition: transform 0.1s ease;
  box-shadow: 0 30px 60px -12px rgba(50, 50, 90, 0.25), 0 18px 36px -18px rgba(0, 0, 0, 0.3), 0 -12px 36px -8px rgba(0, 0, 0, 0.025);
}

.pro-pricing-intro {
  background: #f6f9fc;
  border-radius: 8px;
  align-items: flex-start;
}
.pro-pricing-intro img {
  width: 6.5rem;
}

.pro-pricing-value {
  margin: 0;
  font-weight: 600;
  width: 100%;
}
.pro-pricing-value h2 {
  color: #ad8a56;
}
.pro-pricing-value.pro h2 {
  color: #f5be58;
}
.pro-pricing-value .price-tag {
  display: flex;
  align-items: center;
}
.pro-pricing-value .price-tag h2 {
  font-size: 2rem;
  margin-right: 1.5rem;
  margin-left: -0.8rem;
}

.price-matrix {
  font-family: "Mukta", sans-serif;
}
.price-matrix .offer {
  margin-top: 0.5rem;
  padding: 0.25rem;
  padding-left: 0.4rem;
  font-weight: 500;
  background: #d7ecff;
  color: #494bae;
  background: #fde2dd;
  color: #a31d4e;
}

.price {
  text-decoration: line-through;
  color: #919191;
  font-weight: 300;
  padding: 0.5rem 0;
}
.price h4 {
  font-size: 1.6rem;
}
.price p {
  font-size: 1.1rem;
  margin-left: 1rem;
}

.offer-price {
  margin-top: -1rem;
}
.offer-price p {
  font-size: 1.4rem;
  margin-left: 0.75rem;
  color: #3ecf8e;
}
.offer-price h4 {
  font-size: 2.2rem;
  font-weight: 600;
  color: #6672e5;
}

.pro-pricing-feature {
  border-top: 0.5px solid #e9f4f4;
  padding: 0.5rem 0rem;
  padding: 0 1.5rem;
}
.pro-pricing-feature img {
  width: 1.2rem;
  padding-right: 0.8rem;
  display: inline-block;
}
.pro-pricing-feature p {
  font-size: 1.1rem;
  padding: 0.65rem 0rem;
  font-weight: 500;
  color: #525f7f;
  font-family: "Lato", sans-serif;
}
.pro-pricing-feature .general-feature {
  color: #8b8b8b;
}

.general-feature {
  text-decoration: line-through;
  color: grey;
}

.premium, .standard {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: flex-end;
}
.premium .btn, .standard .btn {
  padding: 0.5rem 1rem;
  padding-right: 1.5rem;
  background: #32325D;
}

.premium-btn .premium-btn-img {
  display: inline-block;
  width: 2rem;
}

.pricing-info-head {
  padding: 5rem;
}
.pricing-info-head h2 {
  font-family: "Lato", sans-serif;
  font-weight: 700;
  font-size: 2.8rem;
  color: #32325d;
}
.pricing-info-head img {
  width: 4%;
  display: inline-block;
  margin-right: 1rem;
}

.pricing-plan {
  padding-bottom: 5rem;
}

.plan1 {
  padding-right: 1rem;
}

.plan2 {
  padding-left: 1rem;
}

@media screen and (max-width: 768px) {
  .pro-pricing-feature {
    flex-wrap: nowrap;
  }

  .pricing-head {
    flex-direction: column;
    align-items: center;
    justify-content: center;
  }
  .pricing-head h2 {
    font-size: 2.4rem;
  }
  .pricing-head img {
    width: 50px;
  }

  .pro-pricing-value {
    margin: 0 auto;
  }
  .pro-pricing-value .price-tag {
    flex-wrap: wrap;
    flex-direction: column;
    align-items: center;
    justify-content: center;
  }

  .pro-pricing-intro {
    flex-direction: column;
    align-items: center;
    justify-content: center;
  }
  .pro-pricing-intro img {
    width: 6.5rem;
  }

  .price-tag h2 {
    font-size: 2rem;
    margin-right: 0;
    margin-left: 0;
  }

  .pro-pricing:last-child {
    margin-bottom: 0;
  }
  .pro-pricing:hover {
    transform: none;
    transition: none;
    box-shadow: 4px 4px 10px rgba(0, 0, 0, 0.5);
  }

  .premium {
    margin-bottom: 4rem;
  }

  .premium, .standard {
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
  }

  .premium .btn, .standard .btn {
    padding: 0.5rem 1rem;
    padding-right: 1.5rem;
    width: 50%;
    margin-top: 2rem;
  }
}
.more-testimonial {
  background: #e6ebf1;
}

.more-testimonial-head {
  padding-bottom: 3rem;
}
.more-testimonial-head h2 {
  text-align: center;
  font-family: "Lato", sans-serif;
  font-weight: 700;
  font-size: 2.8rem;
  color: #32325d;
}
.more-testimonial-head img {
  width: 3rem;
  margin-right: 1rem;
  display: inline-block;
}

.tweets {
  border-radius: 20px;
  padding: 0 0.5rem;
}

.tweetgroup .tweet {
  border-radius: 20px;
  padding: 0.5rem;
  width: 50%;
  flex: 1 1 auto;
  align-self: flex-start;
}

@media screen and (max-width: 768px) {
  .more-testimonial-head {
    flex-direction: column;
    text-align: center;
  }
  .more-testimonial-head h2 {
    font-size: 2.4rem;
  }
  .more-testimonial-head img {
    width: 50px;
  }
}
.testimonial-heading {
  background: #e6ebf1;
}

.testimonial-head {
  margin-bottom: 3rem;
}
.testimonial-head h2 {
  font-size: 2.8rem;
  font-family: "Lato", sans-serif;
  color: #32325d;
  text-align: center;
  font-weight: 700;
}
.testimonial-head img {
  display: inline-block;
  width: 3rem;
  margin-right: 1rem;
}

.testimonials {
  position: relative;
  padding: 2.5rem 0;
  background: #32325D;
  color: white;
  font-family: "Mukta", sans-serif;
}
.testimonials blockquote {
  font-family: "Source Sans Pro";
}

.author {
  flex-basis: 40%;
  justify-content: flex-start;
}
.author .author-img {
  object-fit: cover;
  width: 80px;
  height: 80px;
  border-radius: 50%;
  margin-right: 1.5rem;
}
.author .name {
  color: #fcd669;
  text-transform: uppercase;
  font-weight: 600;
  font-size: 19px;
  margin-bottom: 0.375rem;
}

blockquote {
  font-family: "Lato", sans-serif;
  flex-basis: 75%;
  padding-left: 1.25rem;
  font-size: 1.5rem;
  line-height: 2;
  font-style: italic;
}
blockquote::before {
  content: "";
  width: 12px;
  height: 9px;
  color: #fcd669;
  position: relative;
  display: inline-block;
  top: -7px;
  background: url("../media/DOUBLE QUOTE2-01.svg");
}
blockquote::after {
  content: "";
  width: 12px;
  height: 9px;
  color: #fcd669;
  position: relative;
  display: inline-block;
  top: -7px;
  background: url("../media/DOUBLE QUOTE-01.svg");
}

.carousel-wrapper {
  overflow: hidden;
  width: 90%;
  margin: auto;
  display: flex;
  align-items: center;
  justify-content: center;
  min-height: 17.2rem;
}

/* Apply 'border-box' to 'box-sizing' so border and padding is included in the width and height. */
.carousel-wrapper * {
  box-sizing: border-box;
}

/* We'll be using the 'transform' property to move the carousel's items, so setting the 'transform-style' to 'preserve-3d' will make sure our nested elements are rendered properly in the 3D space. */
.carousel {
  -webkit-transform-style: preserve-3d;
  -moz-transform-style: preserve-3d;
  transform-style: preserve-3d;
}

/* By default we're hiding items (except the initial one) until the JS initiates. Elements are absolutely positioned with a width of 100% (as we're styling for mobile first), letting the content's height dictate the height of the carousel. Our magic property here for all our animation needs is 'transition', taking the properties we wish to animate 'transform' and 'opacity', along with the length of time in seconds. */
.carousel__photo {
  opacity: 0;
  position: absolute;
  top: 0;
  width: 100%;
  margin: auto;
  padding: 1rem 5rem;
  z-index: 100;
  transition: transform 0.5s, opacity 0.5s, z-index 0.5s;
}

/* Display the initial item and bring it to the front using 'z-index'. These styles also apply to the 'active' item. */
.carousel__photo.initial,
.carousel__photo.active {
  opacity: 1;
  position: relative;
  z-index: 900;
}

/* Set 'z-index' to sit behind our '.active' item. */
.carousel__photo.prev,
.carousel__photo.next {
  z-index: 800;
}

/* Translate previous item to the left */
.carousel__photo.prev {
  transform: translateX(-100%);
}

/* Translate next item to the right */
.carousel__photo.next {
  transform: translateX(100%);
}

/* Style navigation buttons to sit in the middle, either side of the carousel. */
.carousel__button--prev,
.carousel__button--next {
  position: absolute;
  top: 50%;
  width: 3rem;
  height: 3rem;
  transform: translateY(-50%);
  border-radius: 50%;
  cursor: pointer;
  z-index: 1001;
  /* Sit on top of everything */
  background: #6772e5;
  transition: all 0.15s ease;
  /*  opacity: 0;  Hide buttons until carousel is initialised 
    transition:opacity 1s;*/
  display: flex;
  align-items: center;
  justify-content: center;
  box-shadow: 0 4px 6px rgba(50, 50, 93, 0.11), 0 1px 3px rgba(0, 0, 0, 0.08);
}
.carousel__button--prev:hover,
.carousel__button--next:hover {
  background: #7795f8;
  box-shadow: 0 7px 14px rgba(50, 50, 93, 0.1), 0 3px 6px rgba(0, 0, 0, 0.08);
}
.carousel__button--prev:active,
.carousel__button--next:active {
  background: #555abf;
  box-shadow: 0 6px 12px -2px rgba(50, 50, 93, 0.25), 0 3px 7px -3px rgba(0, 0, 0, 0.3);
}

.carousel__button--next {
  right: 3rem;
}

.carousel__button--prev {
  left: 3rem;
}

/* Use pseudo elements to insert arrows inside of navigation buttons */
.carousel__button--prev::after,
.carousel__button--next::after {
  content: "➜";
  position: absolute;
  width: 10px;
  height: 10px;
  top: 28%;
  left: 44%;
}

.carousel__button--next::after {
  left: 36%;
}

.carousel__button--prev::after {
  transform: rotateY(180deg);
}

.dots {
  display: flex;
  align-items: center;
  justify-content: center;
  margin-top: 30px;
}

.dot {
  width: 10px;
  height: 10px;
  border-radius: 5px;
  background-color: grey;
  margin: 5px;
}

.content-wrapper {
  overflow: hidden;
}

.testimonial {
  width: 100%;
  position: absolute;
  left: -100vw;
  transition: left 3s ease;
}
.testimonial.inactive {
  left: 100vw;
  opacity: 0.5;
  transition: left 2s ease;
}
.testimonial.active {
  left: 0;
  display: flex !important;
}

.nav-right {
  position: relative;
  right: -50%;
}

.nav-left {
  position: relative;
  left: -50%;
}

.active-dot {
  background-color: white;
}

@media screen and (max-width: 768px) {
  .testimonial-head {
    flex-direction: column;
    align-items: center;
    justify-content: center;
  }
  .testimonial-head img {
    width: 50px;
  }
  .testimonial-head h2 {
    font-size: 2.4rem;
  }

  blockquote {
    flex-basis: 100%;
    letter-spacing: 0.01rem;
    line-height: 1.6;
    margin-top: 1rem;
  }

  .author {
    flex-basis: 100%;
    flex-direction: column;
    text-align: center;
  }
  .author .title {
    width: 100%;
  }
  .author .name {
    margin-bottom: 0;
  }

  .description {
    margin-top: 1rem;
  }
}
.footer {
  background: #32325d;
  padding: 5rem 0;
}

.footer-flex {
  align-items: flex-start;
}

.footer-col1-2 {
  flex: 0 1 40%;
}

.footer-links {
  flex: 0 1 60%;
}

.footer-col2 {
  display: flex;
  align-items: flex-start;
  justify-content: space-between;
  margin-top: -1rem;
}

.footer-logo svg {
  width: 100px;
}

.footer-text {
  font-size: 0.9rem;
  color: #929698;
  padding-top: 1rem;
}

.links {
  width: 50%;
}
.links h4 {
  color: #dad6d6;
  margin-bottom: 0.4rem;
}

.social h4 {
  color: #dad6d6;
  margin-bottom: 0.7rem;
}

.quick-links a {
  text-decoration: none;
  font-size: 0.9rem;
  color: #929698;
  margin-top: 1rem;
}
.quick-links a:hover {
  color: #888806;
}

.social-flex img {
  width: 48px;
  display: inline-block;
  margin-right: 1rem;
}
.social-flex img:hover {
  opacity: 0.6;
  transform: translateY(-1px);
  transition: all 0.2s ease-in-out;
}

.footer-copyright {
  margin-top: 3rem;
  text-align: center;
  font-size: 0.85rem;
  font-weight: 300;
  color: rgba(221, 234, 240, 0.2);
}

@media screen and (max-width: 768px) {
  .footer {
    letter-spacing: 0.03rem;
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: center;
  }

  .footer-flex {
    flex-direction: column;
    align-items: center;
    justify-content: center;
  }

  .social-flex {
    text-align: center;
    margin: 0 auto;
  }

  .footer-col2 {
    flex-wrap: wrap;
    flex-direction: column;
    align-items: center;
    justify-content: center;
  }

  .footer-col1-2 {
    width: 100%;
  }

  .links {
    width: 100%;
  }

  .social {
    width: 100%;
  }

  .links {
    margin: 3rem 0;
  }
  .links a {
    font-size: 1rem;
  }
}
.terms {
  padding: 5rem 0;
}
.terms h1 {
  padding: 3rem 0;
  text-align: center;
  font-weight: 700;
  font-family: "Lato", sans-serif;
  margin: 0 auto;
  color: #32325d;
}
.terms ul, .terms p {
  padding: 0.4rem 0;
  font-size: 1.2rem;
}
.terms h5 {
  padding: 2rem 0;
}

.termscontainer {
  max-width: 900px;
  margin: 0 auto;
}

.refund {
  padding: 5rem 0;
}
.refund h1 {
  padding: 3rem 0;
  text-align: center;
  font-weight: 700;
  font-family: "Lato", sans-serif;
  margin: 0 auto;
  color: #32325d;
}
.refund p {
  padding: 0.4rem 0;
  font-size: 1rem;
  line-height: 1.6;
  color: #6b7c92;
}

.refundcontainer {
  max-width: 900px;
  margin: 0 auto;
}

.privacy {
  padding: 5rem 0;
}
.privacy h1 {
  padding: 3rem 0;
  text-align: center;
  font-weight: 700;
  font-family: "Lato", sans-serif;
  margin: 0 auto;
  color: #32325d;
}
.privacy ul, .privacy p {
  padding: 0.6rem 0;
  font-size: 1.2rem;
}
.privacy li {
  padding: 0.4rem 0;
}
.privacy .bold {
  font-weight: 800;
}

.privacycontainer {
  max-width: 900px;
  margin: 0 auto;
}

.pricing-policy {
  padding: 5rem 0;
}
.pricing-policy h1 {
  padding: 3rem 0;
  text-align: center;
  font-weight: 700;
  font-family: "Lato", sans-serif;
  margin: 0 auto;
  color: #32325d;
}
.pricing-policy p {
  padding: 0.4rem 0;
  font-size: 1.2rem;
}

.pricing-policycontainer {
  max-width: 900px;
  margin: 0 auto;
}

.faqs {
  font-family: "Source Sans Pro";
  font-family: #f6f9fc;
}

.faq-container {
  max-width: 720px;
  margin: 0 auto;
}

.faq-heading {
  text-align: center;
  color: #32325d;
  font-weight: 700;
  margin-bottom: 3rem;
  font-size: 2.8rem;
}

.question {
  color: #008168;
  font-size: 1.5rem;
  font-weight: 600;
}

.answer {
  padding: 0.5rem 0 2rem 0;
  color: #525f7f;
  font-size: 17px;
  font-weight: 500;
  letter-spacing: 0.013rem;
}
.answer b {
  font-weight: 600;
  font-size: 1.4rem;
  padding-right: 0.5rem;
}

@media screen and (max-width: 768px) {
  .faq-container {
    padding: 0 2rem;
  }

  .faq-heading {
    font-size: 2.4rem;
  }

  .answer {
    padding: 0.5rem 0 2rem 0;
    font-size: 1.1rem;
    font-weight: 500;
    letter-spacing: 0.013rem;
  }
}
.feature-container {
  display: flex;
  text-align: center;
}
@media screen and (max-width: 768px) {
  .feature-container {
    display: block;
  }
}

.feature-item {
  padding: 0 20px;
}
@media screen and (max-width: 768px) {
  .feature-item {
    margin-bottom: 4rem;
  }
  .feature-item:last-child {
    margin-bottom: 0;
  }
}

.feature-item__header {
  min-height: 9rem;
}
@media screen and (max-width: 768px) {
  .feature-item__header {
    min-height: auto;
  }
}

.feature-item__heading {
  font-size: 1.6rem;
  line-height: 1.5;
  font-weight: 400;
  margin-top: 1.2rem;
}

.feature__icon {
  height: 40px;
}

.feature-item__intro {
  font-size: 1.2rem;
  margin-top: 1.2rem;
}

/*# sourceMappingURL=style.cs.map */
