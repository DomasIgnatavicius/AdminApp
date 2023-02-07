import React, { useState,useEffect } from "react";
import {
    Box,
    Card,
    CardActions,
    CardContent,
    Collapse,
    Button,
    Typography,
    Rating,
    useTheme,
    useMediaQuery,
    Checkbox
} from "@mui/material";
import Header from "../../components/Header";
import { useGetProductsQuery } from "../../state/api";
import FlexBetween from "../../components/FlexBetween";
import TextField from '@mui/material/TextField';
import Dialog from '@mui/material/Dialog';
import DialogActions from '@mui/material/DialogActions';
import DialogContent from '@mui/material/DialogContent';
import DialogContentText from '@mui/material/DialogContentText';
import DialogTitle from '@mui/material/DialogTitle';


const Product = ({
    id,
    name,
    price,
    description,
    rating,
    category
}) => {
    const theme = useTheme();
    function handleUpdate(e) {
        console.log(e);
    }
    function handleDelete(e) {
        const requestOptions = {
            method: 'DELETE',
            headers: { 'Content-Type': 'application/json' },
        };
        fetch(`/api/Product/products/deleteproduct/${id}`, requestOptions)
            .then(response => response.json())
            .then(data => console.log(data));
        window.location.reload(false);
    }
    const [open, setOpen] = useState(false);

    const handleClickOpen = (e) => {
        setOpen(true);
        console.log(e);
    };

    const handleClose = () => {
        setOpen(false);
    };
    const [Name, setName] = useState('');
    const [Price, setPrice] = useState('');
    const [Description, setDescription] = useState('');
    const [ProductRating, setProductRating] = useState('');
    const [Supply, setSupply] = useState('');
    function handleSubmit() {
        const updateProductDto={
            Name: Name,
            Price: Price,
            Description: Description,
            ProductRating: ProductRating,
            Supply: Supply
        }
        const requestOptions = {
            method: 'PUT',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify({updateProductDto})
        };
        fetch(`/api/Product/products/updateproduct/${id}`, requestOptions)
            .then(response => response.json())
            .then(data => console.log(data));
        console.log(updateProductDto);
        console.log(id);
    }
    return (
        <Card
            sx={{
                width: "13rem",
                backgroundImage: "none",
                backgroundColor: theme.palette.background.alt,
                borderRadius: "0.55rem",
            }}
        >
            <div>
                <Dialog open={open} onClose={handleClose}>
                    <DialogTitle>Update Product</DialogTitle>
                    <DialogContent>
                        <form onSubmit={ handleSubmit}>
                            <TextField value={Name} onInput={e=> setName(e.target.value )} autoFocus margin="dense" id="name" label="Name" type="text" fullWidth variant="outlined"/>
                            <TextField value={Price} onInput={e => setPrice(e.target.value) } autoFocus margin="dense" id="price" label="Price" type="text" fullWidth variant="outlined"/>
                            <TextField value={Description} onInput={e => setDescription(e.target.value) } autoFocus margin="dense" id="description" label="Description" type="text" fullWidth variant="outlined" />
                            <TextField value={ProductRating} onInput={e => setProductRating(e.target.value) } autoFocus margin="dense" id="rating" label="Rating" type="text" fullWidth variant="outlined" />
                            <TextField value={Supply} onInput={e => setSupply(e.target.value) } autoFocus margin="dense" id="supply" label="Supply" type="text" fullWidth variant="outlined"  />
                        </form>
                    </DialogContent>
                    <DialogActions>
                        <Button size="medium" color="error" variant="contained" onClick={handleClose}>Cancel</Button>
                        <Button type="submit" size="medium" color="success" variant="contained" onClick={handleSubmit}>Update</Button>
                    </DialogActions>
                </Dialog>
            </div>
            <CardContent>
                <Typography
                    sx={{ fontSize: 14 }}
                    color={theme.palette.secondary[700]}
                    gutterBottom
                >
                    {category}
                </Typography>
                <Typography variant="h5" component="div">
                    {name}
                </Typography>
                <Typography sx={{ mb: "1.5rem" }} color={theme.palette.secondary[400]}>
                    ${Number(price).toFixed(2)}
                </Typography>
                <Rating value={rating} readOnly />
                <Typography sx={{ mb: "1rem",height:"2rem" }} variant="body2">{description}</Typography>

                <FlexBetween>
                    <Button onClick={e => handleClickOpen(e.target.value)} value={id} size="small" color="success" variant="contained">Update</Button>
                    <Button onClick={e => handleDelete(e.target.value)} value={id} size="small" color="error" variant="contained">Delete</Button>
                </FlexBetween>


            </CardContent>

        </Card>
    )

}

const Products = () => {
    const { data, isLoading } = useGetProductsQuery();
    const isNonMobile = useMediaQuery("(min-width: 1000px)");
    console.log(data);

    return (
        <Box m="1.5rem 2.5rem">
            <Header title="PRODUCTS" subtitle="See your list of products." />
            {data || !isLoading ? (
                <Box
                    mt="20px"
                    display="grid"
                    gridTemplateColumns="repeat(4, minmax(0, 1fr))"
                    justifyContent="space-between"
                    rowGap="20px"
                    columnGap="1.33%"
                    sx={{
                        "& > div": { gridColumn: isNonMobile ? undefined : "span 4" },
                    }}
                >
                    {data.map(
                        ({
                            id,
                            name,
                            description,
                            price,
                            rating,
                            category
                        }) => (
                            <Product
                                key={id}
                                id={id}
                                name={name}
                                description={description}
                                price={price}
                                rating={rating}
                                category={category}
                            />
                        )
                    )}
                </Box> ) : ( <>Loading...</> )
            }
        </Box>    
    )
}

export default Products;