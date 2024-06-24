import { useEffect, useState } from 'react';

const maxMobileWidth = 480;
const isMobile = () => window.innerWidth <= maxMobileWidth;

interface ScreenSize {
    width: number;
    height: number;
    isMobile: boolean;
}

export function useScreenSize() {
    const [screenSize, setScreenSize] = useState<ScreenSize>({
        width: window.innerWidth,
        height: window.innerHeight,
        isMobile: isMobile()
    });

    useEffect(() => {
        const onResize = () => setScreenSize({
            width: window.innerWidth,
            height: window.innerHeight,
            isMobile: isMobile()
        });

        window.addEventListener('resize', onResize);
        return () => window.removeEventListener('resize', onResize);
    }, []);
    
    return screenSize;
}

export default useScreenSize;