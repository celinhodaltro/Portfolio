export function init() {
    const reduceMotion = window.matchMedia('(prefers-reduced-motion: reduce)').matches;
    const revealables = document.querySelectorAll('[data-reveal]');

    if (reduceMotion || !('IntersectionObserver' in window)) {
        revealables.forEach(element => element.classList.add('is-visible'));
    } else {
        const revealObserver = new IntersectionObserver(entries => {
            entries.forEach(entry => {
                if (entry.isIntersecting) {
                    entry.target.classList.add('is-visible');
                    revealObserver.unobserve(entry.target);
                }
            });
        }, { rootMargin: '0px 0px -10% 0px', threshold: 0.08 });

        revealables.forEach(element => revealObserver.observe(element));
    }

    const links = new Map();
    document.querySelectorAll('[data-nav]').forEach(link => links.set(link.dataset.nav, link));

    if ('IntersectionObserver' in window && links.size > 0) {
        const sectionObserver = new IntersectionObserver(entries => {
            entries.forEach(entry => {
                if (!entry.isIntersecting) {
                    links.get(entry.target.id)?.removeAttribute('aria-current');
                    return;
                }

                links.forEach((link, id) => {
                    if (id === entry.target.id) {
                        link.setAttribute('aria-current', 'true');
                    } else {
                        link.removeAttribute('aria-current');
                    }
                });
            });
        }, { rootMargin: '-45% 0px -50% 0px' });

        links.forEach((_, id) => {
            const section = document.getElementById(id);
            if (section) {
                sectionObserver.observe(section);
            }
        });
    }

    const header = document.querySelector('[data-header]');
    if (header) {
        const update = () => header.classList.toggle('is-scrolled', window.scrollY > 12);
        update();
        window.addEventListener('scroll', update, { passive: true });
    }
}
