// ====================================================================
// Modal

function lockScrollBody(isHidden) {
    if (isHidden) {
        $("body").removeClass(" scroll-locked");
    }
    else {
        $("body").addClass(" scroll-locked");
    }
}

// ====================================================================
