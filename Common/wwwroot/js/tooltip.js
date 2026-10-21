const { computePosition, autoUpdate, offset, flip, shift, arrow } = window.FloatingUIDOM;

let cleanup = null;

export function show(anchor, tooltip, arrowEl, placement) {
    hide();
    cleanup = autoUpdate(anchor, tooltip, async () => {
        const { x, y, placement: final, middlewareData } = await computePosition(anchor, tooltip, {
            placement: placement || 'top',
            strategy: 'fixed',
            middleware: [offset(8), flip(), shift({ padding: 8 }), arrow({ element: arrowEl })]
        });

        Object.assign(tooltip.style, { left: `${x}px`, top: `${y}px` });

        const { x: ax, y: ay } = middlewareData.arrow ?? {};
        const side = { top: 'bottom', right: 'left', bottom: 'top', left: 'right' }[final.split('-')[0]];
        Object.assign(arrowEl.style, {
            left: ax != null ? `${ax}px` : '',
            top: ay != null ? `${ay}px` : '',
            right: '', bottom: '',
            [side]: '-4px'
        });
    });
}

export function hide() {
    cleanup?.();
    cleanup = null;
}
