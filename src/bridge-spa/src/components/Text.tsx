import Typography from "@mui/material/Typography";

interface TextProps {
    children?: React.ReactNode;
    short?: boolean;
    fontSize?: string;
    color?: string;
}
  
const Text: React.FC<TextProps> = (props: TextProps) => {
    return (
        <Typography sx={{
            fontSize: !props.fontSize ? "14px" : props.fontSize,
            color: props.color,
            overflowWrap: 'anywhere',
            display: '-webkit-box',
            overflow: 'hidden',
            WebkitBoxOrient: 'vertical',
            WebkitLineClamp: props.short ? 1 : undefined }}>
            { props.children }
        </Typography>
    );
};

export default Text;