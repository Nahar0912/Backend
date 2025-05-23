﻿using System.ComponentModel.DataAnnotations;

namespace Backend.DTOs
{
    public class LabelDto
    {
        [Required(ErrorMessage = "BAR_CODE is required.")]
        [MaxLength(32, ErrorMessage = "BAR_CODE must not exceed 32 characters.")]
        public required string BAR_CODE { get; set; }

        [Required(ErrorMessage = "ORDER_QUANTITY is required.")]
        public required string ORDER_QUANTITY { get; set; }

        public string? BATCH_LOT_NO { get; set; }
        public string? COLOR_CODE { get; set; }
        public string? ARTICLE_NO { get; set; }
        public DateTime? DATE { get; set; }
        public string? CARTON_INSIDE_QUANTITY { get; set; }
        public string? TEX_NO { get; set; }
        public string? LENGTH { get; set; }
        public string? CONE_ROUND_TEX { get; set; }
        public string? NO_OF_STICKER_WITH_FULL_BOX { get; set; }
        public string? NO_OF_LOOSE_QUANTITY_IN_LAST_STICKER { get; set; }
        public string? PRINT_QUANTITY_FOR_LOOSE_STICKER { get; set; }
        public string? PRINT_QUANTITY_FOR_CONE_ROUND_STICKER { get; set; }
        public string? AMANN_COLOR_CODE { get; set; }
        public string? COMPETETOR_COLOR_CODE { get; set; }
    }

    public class UpdateLabelDto
    {
        public string? BAR_CODE { get; set; }
        public string? ORDER_QUANTITY { get; set; }
        public string? BATCH_LOT_NO { get; set; }
        public string? COLOR_CODE { get; set; }
        public string? ARTICLE_NO { get; set; }
        public DateTime? DATE { get; set; }
        public string? CARTON_INSIDE_QUANTITY { get; set; }
        public string? TEX_NO { get; set; }
        public string? LENGTH { get; set; }
        public string? CONE_ROUND_TEX { get; set; }
        public string? NO_OF_STICKER_WITH_FULL_BOX { get; set; }
        public string? NO_OF_LOOSE_QUANTITY_IN_LAST_STICKER { get; set; }
        public string? PRINT_QUANTITY_FOR_LOOSE_STICKER { get; set; }
        public string? PRINT_QUANTITY_FOR_CONE_ROUND_STICKER { get; set; }
        public string? AMANN_COLOR_CODE { get; set; }
        public string? COMPETETOR_COLOR_CODE { get; set; }
    }

}
