// Wait for the DOM to be fully loaded
document.addEventListener('DOMContentLoaded', function() {
    // Smooth scrolling for navigation links
    document.querySelectorAll('a[href^="#"]').forEach(anchor => {
        anchor.addEventListener('click', function (e) {
            e.preventDefault();
            const target = document.querySelector(this.getAttribute('href'));
            if (target) {
                target.scrollIntoView({
                    behavior: 'smooth',
                    block: 'start'
                });
            }
        });
    });

    // Add active class to navigation items on scroll
    window.addEventListener('scroll', function() {
        const sections = document.querySelectorAll('section');
        const navLinks = document.querySelectorAll('nav ul li a');

        let current = '';

        sections.forEach(section => {
            const sectionTop = section.offsetTop;
            if (pageYOffset >= sectionTop - 60) {
                current = section.getAttribute('id');
            }
        });

        navLinks.forEach(link => {
            link.classList.remove('active');
            if (link.getAttribute('href').substring(1) === current) {
                link.classList.add('active');
            }
        });
    });

    // Get all booking buttons
    const bookingButtons = document.querySelectorAll('.book-appointment, .nav-book-appointment');

    // Add click event to all booking buttons
    bookingButtons.forEach(button => {
        button.addEventListener('click', function(e) {
            e.preventDefault();
            const bookingSection = document.getElementById('book-appointment');
            bookingSection.scrollIntoView({
                behavior: 'smooth',
                block: 'start'
            });
        });
    });

    //// Add click event to individual doctor booking buttons
    //const doctorBookingButtons = document.querySelectorAll('.book-doctor-btn');
    //doctorBookingButtons.forEach(button => {
    //    button.addEventListener('click', function(e) {
    //        e.preventDefault();
    //        const doctorName = this.closest('.doctor-info').querySelector('h3').textContent;
    //        alert(`Booking appointment with ${doctorName}. This feature will be implemented soon.`);
    //    });
    //});

    // Search and filter functionality
//    const searchInput = document.querySelector('.search-doctors');
//    const specialtyFilter = document.querySelector('.filter-specialty');
//    const doctorCards = document.querySelectorAll('.doctor-card');

//    function filterDoctors() {
//        const searchTerm = searchInput.value.toLowerCase();
//        const selectedSpecialty = specialtyFilter.value.toLowerCase();

//        doctorCards.forEach(card => {
//            const doctorName = card.querySelector('h3').textContent.toLowerCase();
//            const doctorSpecialty = card.querySelector('.specialty').textContent.toLowerCase();
//            const nameMatch = doctorName.includes(searchTerm);
//            const specialtyMatch = selectedSpecialty === '' || doctorSpecialty.includes(selectedSpecialty);

//            if (nameMatch && specialtyMatch) {
//                card.style.display = 'block';
//            } else {
//                card.style.display = 'none';
//            }
//        });
//    }

//    searchInput.addEventListener('input', filterDoctors);
//    specialtyFilter.addEventListener('change', filterDoctors);