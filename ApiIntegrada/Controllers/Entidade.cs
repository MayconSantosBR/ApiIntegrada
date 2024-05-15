namespace ApiIntegrada.Controllers
{
    public class Entidade
    {
        public string _id { get; set; }
        public string listing_url { get; set; }
        public string name { get; set; }
        public string summary { get; set; }
        public string space { get; set; }
        public string description { get; set; }
        public string neighborhood_overview { get; set; }
        public string notes { get; set; }
        public string transit { get; set; }
        public string access { get; set; }
        public string interaction { get; set; }
        public string house_rules { get; set; }
        public string property_type { get; set; }
        public string room_type { get; set; }
        public string bed_type { get; set; }
        public string minimum_nights { get; set; }
        public string maximum_nights { get; set; }
        public string cancellation_policy { get; set; }
        public Last_Scraped last_scraped { get; set; }
        public Calendar_Last_Scraped calendar_last_scraped { get; set; }
        public First_Review first_review { get; set; }
        public Last_Review last_review { get; set; }
        public int accommodates { get; set; }
        public int bedrooms { get; set; }
        public int beds { get; set; }
        public int number_of_reviews { get; set; }
        public Bathrooms bathrooms { get; set; }
        public string[] amenities { get; set; }
        public Price price { get; set; }
        public Weekly_Price weekly_price { get; set; }
        public Monthly_Price monthly_price { get; set; }
        public Security_Deposit security_deposit { get; set; }
        public Cleaning_Fee cleaning_fee { get; set; }
        public Extra_People extra_people { get; set; }
        public Guests_Included guests_included { get; set; }
        public Images images { get; set; }
        public Host host { get; set; }
        public Address address { get; set; }
        public Availability availability { get; set; }
        public Review_Scores review_scores { get; set; }
        public Review[] reviews { get; set; }
    }

    public class Last_Scraped
    {
        public DateTime date { get; set; }
    }

    public class Calendar_Last_Scraped
    {
        public DateTime date { get; set; }
    }

    public class First_Review
    {
        public DateTime date { get; set; }
    }

    public class Last_Review
    {
        public DateTime date { get; set; }
    }

    public class Bathrooms
    {
        public string numberDecimal { get; set; }
    }

    public class Price
    {
        public string numberDecimal { get; set; }
    }

    public class Weekly_Price
    {
        public string numberDecimal { get; set; }
    }

    public class Monthly_Price
    {
        public string numberDecimal { get; set; }
    }

    public class Security_Deposit
    {
        public string numberDecimal { get; set; }
    }

    public class Cleaning_Fee
    {
        public string numberDecimal { get; set; }
    }

    public class Extra_People
    {
        public string numberDecimal { get; set; }
    }

    public class Guests_Included
    {
        public string numberDecimal { get; set; }
    }

    public class Images
    {
        public string thumbnail_url { get; set; }
        public string medium_url { get; set; }
        public string picture_url { get; set; }
        public string xl_picture_url { get; set; }
    }

    public class Host
    {
        public string host_id { get; set; }
        public string host_url { get; set; }
        public string host_name { get; set; }
        public string host_location { get; set; }
        public string host_about { get; set; }
        public string host_thumbnail_url { get; set; }
        public string host_picture_url { get; set; }
        public string host_neighbourhood { get; set; }
        public bool host_is_superhost { get; set; }
        public bool host_has_profile_pic { get; set; }
        public bool host_identity_verified { get; set; }
        public int host_listings_count { get; set; }
        public int host_total_listings_count { get; set; }
        public string[] host_verifications { get; set; }
    }

    public class Address
    {
        public string street { get; set; }
        public string suburb { get; set; }
        public string government_area { get; set; }
        public string market { get; set; }
        public string country { get; set; }
        public string country_code { get; set; }
        public Location location { get; set; }
    }

    public class Location
    {
        public string type { get; set; }
        public float[] coordinates { get; set; }
        public bool is_location_exact { get; set; }
    }

    public class Availability
    {
        public int availability_30 { get; set; }
        public int availability_60 { get; set; }
        public int availability_90 { get; set; }
        public int availability_365 { get; set; }
    }

    public class Review_Scores
    {
        public int review_scores_accuracy { get; set; }
        public int review_scores_cleanliness { get; set; }
        public int review_scores_checkin { get; set; }
        public int review_scores_communication { get; set; }
        public int review_scores_location { get; set; }
        public int review_scores_value { get; set; }
        public int review_scores_rating { get; set; }
    }

    public class Review
    {
        public string _id { get; set; }
        public Date date { get; set; }
        public string listing_id { get; set; }
        public string reviewer_id { get; set; }
        public string reviewer_name { get; set; }
        public string comments { get; set; }
    }

    public class Date
    {
        public DateTime date { get; set; }
    }

}